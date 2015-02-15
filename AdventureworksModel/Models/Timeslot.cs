using System;
using System.Collections.Generic;

namespace AdventureworksModel.Models
{
    public partial class Timeslot
    {
        public System.DateTime Date { get; set; }
        public System.TimeSpan Time { get; set; }
        public string Free { get; set; }
        public virtual DaySchedule DaySchedule { get; set; }
    }
}
