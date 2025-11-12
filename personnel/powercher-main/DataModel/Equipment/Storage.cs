using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel
{
    public class Storage:Appliance
    {
        public StorageDescription Description { get; private set; }

        /// <summary>
        /// The current number of kWh in the device
        /// </summary>
        public double Load { get; private set; }

        public double FreeSpace { get => Description.Capacity - Load; }


        public Storage(StorageDescription description, string serialNumber):base(serialNumber)
        {
            Description = description;
        }

        /// <summary>
        /// Give power to the storage.
        /// This is when the efficiency is applied
        /// </summary>
        /// <param name="amount">in [kWh]</param>
        /// <exception cref="Exception">Overload</exception>
        public double Put(double amount)
        {
            if (amount < 0) throw new Exception("Cannot add negative amount to storage");
            Load += amount * (int)Math.Round(Description.Efficiency / 100.0);

            if (Load > Description.Capacity)
            {
                Load = Description.Capacity;
                return Load - Description.Capacity;
            }
            return 0;
        }

        /// <summary>
        /// Take power from the storage
        /// </summary>
        /// <param name="amount">in [kWh]</param>
        /// <returns>The number of kWh actually retrieved. Efficiency was taken into account at storage time</returns>
        /// <exception cref="Exception">Oversollicitated</exception>
        public double Take(double amount)
        {
            if (amount < 0) throw new Exception("Cannot take negative amount from storage");
            if (amount > Load)throw new Exception($"Storage {SerialNumber} oversollicited");
            Load -= amount;
            return amount;
        }

    }
}
