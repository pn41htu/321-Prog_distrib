
using Backend;
using Backend.Protocol;
using DataModel;
using Frontend.Logging;
using Microsoft.Extensions.Logging;
using System;
using System.Reflection;
using System.Text.Json;
using System.Linq;

namespace Frontend
{
    public partial class HouseUI : Form
    {
        private House _house;
        private Agent _agent;
        private ConsumingAppliance _fridge;

        private readonly ILogger _logger;

        public HouseUI(string broker)
        {
            InitializeComponent();
            
            //Technical components
            var loggerFactory=LoggerFactory.Create(
                builder => builder
                    .AddProvider(new RichTextBoxLoggerProvider(txtConsole))
                    .SetMinimumLevel(LogLevel.Debug)
                );
            _logger = loggerFactory.CreateLogger<HouseUI>();
            _agent = new Agent(loggerFactory, broker, OnMessageReceived);

            this.Text = $@"House {_agent.NodeId}";
            
            //Business components
            _house = new House(_agent.NodeId,"pn41htu","La maison de pn41htu");

            this.owner.Text = "pn41htu - " + _agent.NodeId.Substring(0,5);


            ProductiveApplianceDescription description = new("Supersolar",
                500,
                "interdiscount",
                "vd40",
                "Le meilleur Panneau solaire",
                12,
                EnergySource.SUN,
                "b64encodedimage");

            _house.AddAppliance(new ProductiveAppliance(description, "12345"));


            ProductiveApplianceDescription description2 = new("Supersolar",
                500,
                "interdiscount",
                "vd40",
                "Le deuxième meilleur Panneau solaire",
                12,
                EnergySource.SUN,
                "b64encodedimage");

            _house.AddAppliance(new ProductiveAppliance(description, "123456"));


            _fridge = new ConsumingAppliance(new ConsumingApplianceDescription("fridge", 500, "samsung", "SM3248", "this is a nice samsung fridge",
                                                                                     1999.00, ApplianceCategory.Kitchen), "353463443523");
            _house.AddAppliance(_fridge);
            _fridge.TurnOn(true);
        }


        // Avoid race condition on txtConsole
        public new void Show()
        {
            base.Show();
            _agent.Start();
        }
        

        private void OnMessageReceived(Envelope envelope)
        {
            _logger.LogInformation(envelope.ToString());


            ComputeEnergyBalance();


            switch (envelope.Type)
            {
                case MessageType.HELLO:
                    _logger.LogInformation(envelope.SenderId + "Said Hello");
                    break;
                case MessageType.HOUSE_STATUS_REQUEST:
                    _agent.Send(new Envelope("Maison témoin", MessageType.HOUSE_STATUS, JsonSerializer.Serialize(_house)));
                    break;
                case MessageType.TOWN_ENVIRONMENT:
                    try
                    {
                        var environment = JsonSerializer.Deserialize<TownEnvironment>(envelope.Message);
                        time.Invoke(new Action(() =>
                        {
                            _house.Environment = environment;
                            time.Text = $"On est le {environment.DateTime}";
                        }));
                        
                    }
                    catch
                    {
                        _logger.LogWarning("Message bizarre : " + envelope.Message);
                    }
                    break;
            }
        }
        private void ComputeEnergyBalance()
        {
            // _house._appliances.ForEach(x => x.GetType)


            
        }


        private void HouseUI_Load(object sender, EventArgs e)
        {

        }
        
        
    }
}
