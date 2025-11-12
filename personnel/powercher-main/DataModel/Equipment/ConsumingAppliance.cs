using System;
using System.Collections.Generic;

namespace DataModel
{
    /// <summary>
    /// A consuming device
    /// </summary>
    public class ConsumingAppliance: Appliance
    {
        public ConsumingApplianceDescription Description { get; private set; }

        public bool IsActive { get; private set; }

        public WorkingSchedule? Schedule { get; set; } = null;

        /// <summary>
        /// Activate or deactivate the device
        /// </summary>
        /// <param name="turnOn"></param>
        public void TurnOn(bool turnOn)
        {
            IsActive = turnOn;
        }

        public double ConsumingAt(DateTime time)
        {
            if (IsActive) return Description.Power;
            if (Schedule is null) return 0;
            return Description.Power * Schedule.IntensityAt(time);
        }

        public ConsumingAppliance(ConsumingApplianceDescription description, string serialnumber) : base(serialnumber)
        {
            Description = description;
            IsActive = false;
        }

    }
}
