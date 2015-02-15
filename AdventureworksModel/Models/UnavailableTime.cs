using System;
using System.Collections.Generic;

namespace AdventureworksModel.Models
{
    public partial class UnavailableTime
    {
        public System.DateTime Date { get; set; }
        public System.TimeSpan From { get; set; }
        public System.TimeSpan To { get; set; }
        public string Note { get; set; }
        public virtual DaySchedule DaySchedule { get; set; }
    }
}
