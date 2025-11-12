using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel
{
    /// <summary>
    /// Represents a working time span at a certain intensity level
    /// </summary>
    public class WorkingTime
    {

        public TimeOnly Start {  get; init; }
        public TimeOnly End { get; init; }
        public double Intensity { get; init; }

        public WorkingTime(TimeOnly start, TimeOnly end, double intensity)
        {
            Start = start;
            End = end;
            if (intensity <= 0 || intensity > 1.0) throw new Exception("Intensity must be positive and max 1.0");
            Intensity = intensity;
        }

        /// <summary>
        /// Check if a fully qualified datetime falls within one of the working times
        /// </summary>
        public bool Contains(DateTime time)
        {
            return this.Contains(TimeOnly.FromDateTime(time));
        }

        /// <summary>
        /// Check if a specific time of day falls within one of the working times
        /// </summary>
        public bool Contains(TimeOnly time)
        {
            if (Start < End)
            {
                return (time >= Start && time <= End);
            }
            else // time span ends in next day
            {
                return (time >= End || time <= Start);
            }
        }
    }
}
