using System;
using System.Collections.Generic;

namespace DataModel
{
    /// <summary>
    /// An appliance that consumes electrical power
    /// </summary>
    public class ProductiveAppliance : Appliance
    {
        public ProductiveApplianceDescription Description { get; private set; }

        public ProductiveAppliance(ProductiveApplianceDescription description, string serialnumber):base(serialnumber) 
        {
            Description = description;
        }

        public int Supply(int sourceIntensity)
        {
            return (int)(sourceIntensity * Description.Efficiency);
        }

    }
}
