namespace DataModel
{
    public enum EnergySource
    {
        WIND,
        SUN,
        WATER
    }
    /// <summary>
    /// An appliance that can produce electrical power
    /// </summary>
    public class ProductiveApplianceDescription : ApplianceProductDescription
    {
        /// <summary>
        /// The maximum power the device can generate (in [W])
        /// </summary>
        public int Power {  get; private set; }

        public EnergySource Source { get; set; }

        /// <summary>
        /// The % of energy that we can get back.
        /// For example, if I have a device that has a 60% efficiency, it supplies 120 W when it receives an input of 200 W (no matter the energy source)
        /// </summary>
        public int Efficiency { get; private set; }


        public ProductiveApplianceDescription(string name, int power, string brand, string model, string description, double price, EnergySource source, string? image = null)
            : base(name, brand, model, description, price, image)
        {
            Power = power;
            Source = source;
        }

        public override string ToString()
        {
            return $"{base.ToString()} is a productive device";
        }

    }
}
