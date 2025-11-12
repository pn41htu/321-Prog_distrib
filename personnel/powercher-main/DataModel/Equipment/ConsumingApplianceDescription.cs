using System;
using System.Collections.Generic;

namespace DataModel
{
    public enum ApplianceCategory
    {
        Heating,
        Kitchen,
        Cleaning,
        Computing,
        Entertainment,
        Other
    }
    /// <summary>
    /// An electric device that consumes power
    /// </summary>
    public class ConsumingApplianceDescription: ApplianceProductDescription
    {
        /// <summary>
        /// Category of the appliance.
        /// </summary>
        public ApplianceCategory Category { get; private set; }

        /// <summary>
        /// Maximal power consumption of the device (in [W])
        /// </summary>
        public int Power { get; private set; }

        public ConsumingApplianceDescription(string name, int power, string brand, string model, string description, double price, ApplianceCategory category, string? image = null)
            : base(name,brand,model,description,price,image)
        {
            Power = power;
            Category = category;
        }

        public override string ToString()
        {
            return $"{base.ToString()} is a consuming device";
        }
    }
}
