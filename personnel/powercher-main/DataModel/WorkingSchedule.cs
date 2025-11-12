using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel
{
    /// <summary>
    /// Represent the working hours of an appliance over a 24h period
    /// We can define an intensity level, percentage of the maximum (double between 0 and 1)
    /// for each working period
    /// </summary>
    public class WorkingSchedule
    {
        private List<WorkingTime> _periods = new List<WorkingTime>();

        public WorkingSchedule(WorkingTime period)
        {
            _periods.Add(period);
        }

        public void AddWorkingTime(WorkingTime period)
        {
            if (_periods.Any(wt => wt.Contains(period.Start)) || _periods.Any(wt => wt.Contains(period.End)))
            {
                throw new Exception("Conflicting schedule");
            }
            _periods.Add(period);
        }

        /// <summary>
        /// Returns the intensity of work at the given time according to schedule
        /// </summary>
        /// <param name="date"></param>
        /// <returns>Percentage of the fullscale value (0 < val< 1)</returns>
        public double IntensityAt(DateTime date)
        {
            WorkingTime? period = _periods.FirstOrDefault(wt => wt.Contains(date));
            if (period is null) return 0;
            return period.Intensity;
        }
    }
}
