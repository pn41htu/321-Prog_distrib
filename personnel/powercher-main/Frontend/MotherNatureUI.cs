using System.Diagnostics.CodeAnalysis;
using Backend;
using Backend.Protocol;
using DataModel;
using Frontend.Logging;
using Microsoft.Extensions.Logging;

namespace Frontend;

public partial class MotherNatureUI : Form
{
    private const int MAX_WIND_SPEED = 120;

    private ILogger logger;
    private Agent agent;
    private DateTime? simutime = null;
    private TimeSpan delta;
    private double cloudCover = 0.5;
    private int windSpeed = 10;
    private WindDirections windDirection = WindDirections.S;
    private readonly bool _encrypt;


    private Random random = new Random();

    public MotherNatureUI(string broker)
    {
        InitializeComponent();

        var loggerFactory = LoggerFactory.Create(
            builder => builder
                .AddConsole()
                .SetMinimumLevel(LogLevel.Debug)
        );
        logger = loggerFactory.CreateLogger<MotherNatureUI>();
        agent = new Agent(loggerFactory, broker, isMotherNature: true);

        this.Text = $@"MotherNature {agent.NodeId}";
    }

    private void tmrPulse_Tick(object sender, EventArgs e)
    {
        // Change weather conditions
        cloudCover = Math.Max(0, Math.Min(1.0, cloudCover + random.Next(-1, 2) / 1000.0));
        if (random.Next(5) == 0) windSpeed = Math.Max(0, Math.Min(MAX_WIND_SPEED, windSpeed + random.Next(-1, 2)));
        if (random.Next(10) == 0)
        {
            Array values = Enum.GetValues(typeof(WindDirections));
            int currentIndex = Array.IndexOf(values, windDirection);
            int newIndex = (currentIndex + random.Next(-1, 2) + values.Length) % values.Length;
            windDirection = (WindDirections)values.GetValue(newIndex)!;
        }
        double solarPower = SolarPowerCalculator.CalculateSolarPower(simutime ?? DateTime.Now);


        // Publish environment
        TownEnvironment townEnvironment = new TownEnvironment((DateTime)simutime, cloudCover, solarPower, windSpeed, windDirection);
        agent.Send(new Envelope(agent.NodeId, MessageType.TOWN_ENVIRONMENT, townEnvironment.ToJson()));

        // Move time
        simutime += delta; // compute the new simulated time

        // Update display
        lblSimutime.Text = simutime?.ToString("dd.MM.yyyy HH:mm");
        lblSolarPower.Text = solarPower.ToString("P1");
        lblCloudCover.Text = cloudCover.ToString("P1");
        lblWindSpeed.Text = windSpeed.ToString() + " Km/h";
        lblWindDirection.Text = windDirection.ToString();
    }

    private void cmdStart_Click(object sender, EventArgs e)
    {
        tmrPulse.Interval = (int)(nudSimuTick.Value * 1000);
        tmrPulse.Enabled = true;
        simutime = datStart.Value;
        delta = new TimeSpan(0, (int)nudSiminterval.Value, 0); // capture value of interval once
        grpSimu.Visible = false;
    }

}