using System;
using System.Collections.Generic;

namespace DataModel
{
    /// <summary>
    /// An electric device that consumes power
    /// </summary>
    public class ApplianceProductDescription
    {
        /// <summary>
        /// The product name as you see in an advertisment
        /// </summary>
        public string Name { get; private set; }

        public string Brand { get; private set; }

        public string Model { get; private set; }

        public string Description { get; private set; }
        /// <summary>
        /// The purchase price (in CHF)
        /// </summary>
        public double Price { get; private set; }

        /// <summary>
        /// URL or path of product's image
        /// </summary>
        public string? Image {  get; set; }

        public ApplianceProductDescription(string name, string brand, string model, string description, double price, string? image = null)
        {
            Name = name;
            Brand = brand;
            Model = model;
            Description = description;
            Price = price;
            Image = image;
        }

        public override string ToString()
        {
            return $"{Name} ({Brand} {Model})";
        }
    }
}
