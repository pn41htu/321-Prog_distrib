namespace DataModel
{
    /// <summary>
    /// A device that stores energy one way or another (battery, fuel cell, compressed air, gravitational, ...)
    /// </summary>
    public class StorageDescription: ApplianceProductDescription
    {
        /// <summary>
        /// The maximum number of kWh that the device can store
        /// </summary>
        public double Capacity { get; private set; }

        /// <summary>
        /// The % of energy that we can get back.
        /// For example, if I have a device that has a 60% efficiency, I can only take 120 kWh after putting 200 kWh in it
        /// </summary>
        public int Efficiency { get; private set; }

        public StorageDescription(string name, string brand, string model, string description, double price, double capacity, int efficiency, string? image = null)
             : base(name, brand, model, description, price, image)
        {
            Capacity = capacity;
            Efficiency = efficiency;
        }

        public override string ToString()
        {
            return $"{base.ToString()} is a storage";
        }

    }
}
