using System.Text.Json;

namespace DataModel
{
    /// <summary>
    /// The sectors from which the wind can be coming
    /// </summary>
    public enum WindDirections { N, NE, E, SE, S, SW, W, NW }

    /// <summary>
    /// Regroups all the parameters that describe the physical environment of the town
    /// </summary>
    public class TownEnvironment
    {

        /// <summary>
        /// The date and time at which these conditions are (or were) present
        /// </summary>
        public DateTime DateTime { get; private set; }

        /// <summary>
        /// The % of the sky that is hidden by clouds.
        /// Min = 0, Max = 1
        /// It must be applied to determine how much energy a solar panel can generate
        /// </summary>
        /// 
        
        public double Clouds { get; private set; }

        /// </summary>
        /// The % of the maximum energy that can be received by the town
        /// We have 1.0 at noon on June 21st with absolutely no clouds
        /// At noon on December 21st with absolutely no clouds, we have about 0.4
        /// At noon on December 21st with some clouds, we may have 0.25
        /// <summary>
        public double SolarEnergy { get; private set; }

        /// <summary>
        /// Wind speed in km/h
        /// </summary>
        public int WindSpeed { get; private set; }

        /// <summary>
        /// Direction from which the wind is blowing
        /// </summary>
        public WindDirections WindDirection { get; private set; }


        public TownEnvironment(DateTime dateTime, double clouds, double solarEnergy, int windSpeed, WindDirections windDirection)
        {
            DateTime = dateTime;
            Clouds = clouds;
            SolarEnergy = solarEnergy;
            WindSpeed = windSpeed;
            WindDirection = windDirection;
        }

        public string ToJson()
        {
            return JsonSerializer.Serialize(this);
        }


    }
}
