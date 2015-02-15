using System;
using System.Collections.Generic;

namespace AdventureworksModel.Models
{
    public partial class DaySchedule
    {
        public DaySchedule()
        {
            this.Lessons = new List<Lesson>();
            this.Tests = new List<Test>();
            this.Timeslots = new List<Timeslot>();
            this.UnavailableTimes = new List<UnavailableTime>();
        }

        public System.DateTime Date { get; set; }
        public string InstructorUserName { get; set; }
        public System.TimeSpan StartTime { get; set; }
        public System.TimeSpan FinishTime { get; set; }
        public virtual Instructor Instructor { get; set; }
        public virtual ICollection<Lesson> Lessons { get; set; }
        public virtual ICollection<Test> Tests { get; set; }
        public virtual ICollection<Timeslot> Timeslots { get; set; }
        public virtual ICollection<UnavailableTime> UnavailableTimes { get; set; }
    }
}
