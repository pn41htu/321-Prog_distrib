using Backend;
using Backend.Protocol;
using DataModel;
using Microsoft.Extensions.Logging;
using System.Collections.Concurrent;
using System.Text.Json;
using PowerCrypt;

namespace Frontend
{
    public partial class PowerWatchUI : Form
    {
        private ILogger _logger;
        private Agent _agent;
        private readonly bool _encrypt;

        private ConcurrentDictionary<string, Tuple<House, HouseWatcher?>> _houses =
            new(); // list of known houses 

        public PowerWatchUI(string broker)
        {
            InitializeComponent();
            var loggerFactory = LoggerFactory.Create(
                builder => builder
                    .AddConsole()
                    .SetMinimumLevel(LogLevel.Debug)
            );
            _logger = loggerFactory.CreateLogger<PowerWatchUI>();
            _agent = new Agent(loggerFactory, broker, OnMessageReceived);
            _agent.Start();
        }

        private void OnMessageReceived(Envelope envelope)
        {
            if (_encrypt) envelope.Message = EncryptionHelper.DecryptString(envelope.Message);

            switch (envelope.Type)
            {
                case MessageType.HOUSE_STATUS:
                    House house = JsonSerializer.Deserialize<House>(envelope.Message);
                    if (!house.IsValid)
                    {
                        _logger.LogInformation($"Bad house status from {envelope.SenderId}:\n {envelope.Message}");
                        return;
                    }

                    // Update or Create house
                    if (_houses.ContainsKey(house.UniqueName))
                    {
                        _houses[house.UniqueName] =
                            new Tuple<House, HouseWatcher?>(house, _houses[house.UniqueName].Item2);
                    }
                    else
                    {
                        int trials = 0;
                        int maxRetrys = 500;
                        while (!_houses.TryAdd(house.UniqueName, new Tuple<House, HouseWatcher?>(house, null)))
                        {
                            if (trials++ == maxRetrys)
                            {
                                _logger.LogWarning("Giving up adding {} (multi threading issues)",house.UniqueName);
                                break;
                            }
                                
                        }
                        
                        // The form will be created outside the handler
                        // If we do it here, the form can't be updated easily
                    }

                    break;
            }
        }

        /// <summary>
        /// Reorganize (tile) the supervision forms
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCleanup_Click(object sender, EventArgs e)
        {
            Rectangle screen = Screen.FromControl(this).Bounds;
            int topoffset = screen.Top + 5;
            int leftoffset = screen.Left+ 5;
            try
            {
                foreach (KeyValuePair<string, Tuple<House, HouseWatcher?>> entry in _houses)
                {
                    if(entry.Value.Item2!=null)
                    {
                        Rectangle size = entry.Value.Item2!.Bounds;
                        entry.Value.Item2.Bounds = new Rectangle(leftoffset, topoffset, size.Width, size.Height);
                        // Compute next form's position
                        topoffset += size.Height + 5;
                        if (topoffset > screen.Height)
                        {
                            topoffset = screen.Top+5;
                            leftoffset += size.Width + 5;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error cleaning up house");
            }
        }

        private void tmrUpdateView_Tick(object sender, EventArgs e)
        {
            foreach (KeyValuePair<string, Tuple<House, HouseWatcher?>> entry in _houses)
            {
                if (entry.Value.Item2 is null)
                {
                    // Create a display form for this house
                    HouseWatcher newHouseWatcher = new HouseWatcher();
                    _houses[entry.Key] = new Tuple<House, HouseWatcher?>(entry.Value.Item1, newHouseWatcher);
                    newHouseWatcher.StartPosition = FormStartPosition.Manual;
                    newHouseWatcher.Location = Screen.FromControl(this).WorkingArea.Location;
                    newHouseWatcher.Show();
                    btnCleanup_Click(new object(), new EventArgs()); // rearrange display 
                }
                else
                {
                    // Update the existing form
                    entry.Value.Item2.Update(entry.Value.Item1);
                }
            }

            // Request status from everyone
            _agent.Send(new Envelope(_agent.NodeId, MessageType.HOUSE_STATUS_REQUEST, ""));
        }

        /// <summary>
        /// Trash all display forms (they will respawn when statuses come in)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdReset_Click(object sender, EventArgs e)
        {
            _houses.ToList().ForEach(house => { house.Value.Item2.Dispose(); });
            _houses.Clear();
        }
    }
}