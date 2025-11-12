using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel
{
    public class Appliance
    {
        public Appliance(string serialNumber)
        {
            SerialNumber = serialNumber;
        }

        public string SerialNumber { get; private set; }
    }
}
