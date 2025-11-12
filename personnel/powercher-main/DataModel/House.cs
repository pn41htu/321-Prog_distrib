using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace DataModel
{
    /// <summary>
    /// A house, with all its characteristics, represented at a certain time found in the TownEnvironment
    /// </summary>
    public class House
    {
        /// <summary>
        /// A name that identifies the house
        /// It is to be used in technical context (links, logs, ...) but never displayed
        /// </summary>
        public string UniqueName { get; protected set; }

        /// <summary>
        /// A name that is visible to the user
        /// It must never be used for technical purposes
        /// </summary>
        public string DisplayName { get; protected set; }

        /// <summary>
        /// A full and free description text
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// The list of all appliances inside the house.
        /// They can be of any type: Producing, Consuming or Storage
        /// </summary>
        [JsonIgnore]
        private List<Appliance> _appliances;

        /// <summary>
        /// A specific storage that sits at the entry point of the electrical power of the house.
        /// Every kWh that enters the house goes in it.
        /// The devices of the house only get or supply their energy to this buffer.
        /// If this buffer is overdrawn, the house "pète les plombs"
        /// </summary>
        public Storage UPS {  get; }

        /// <summary>
        /// The source for time, and envrionmental info
        /// </summary>
        public TownEnvironment? Environment { get; set; }

        /// <summary>
        /// Tells if the model can be used (after deserialization)
        /// </summary>
        public bool IsValid { get => (UniqueName != null && DisplayName != null); }

        /// <summary>
        /// The amount of cash available for purchases
        /// </summary>
        public double Cash {  get; set; }

        /// <summary>
        /// The amount of energy left after substracting the total consumption from the total production
        /// This value is computed when a new time value comes in from Mother Nature, taking into account
        /// the time elapsed since the previous one
        /// </summary>
        public double EnergeticBalance { get; }

        [JsonConstructor]
        public House(string uniqueName, string displayName, string description, TownEnvironment environment, double cash) : this(uniqueName, displayName, description)
        {
            UPS = new Storage(Catalog.Storages[0],"0000");
            Environment = environment;
            Cash = cash;
        }

        public House(string uniqueName, string displayName, double cash, TownEnvironment environment)
        {
            UniqueName = uniqueName;
            DisplayName = displayName;
            Cash = cash;
            Environment = environment;
            _appliances = new List<Appliance>();
        }

        public House(string uid, string displayName, string description)
        {
            this.UniqueName = uid;
            this.DisplayName = displayName;
            this.Description = description;
            _appliances = new List<Appliance>();
        }
        
    }
}
