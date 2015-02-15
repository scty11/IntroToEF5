using System;
using System.Collections.Generic;

namespace AdventureworksModel.Models
{
    public partial class Instructor
    {
        public Instructor()
        {
            this.DaySchedules = new List<DaySchedule>();
            this.Lessons = new List<Lesson>();
            this.Tests = new List<Test>();
        }

        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string ContactNo { get; set; }
        public string EDINumber { get; set; }
        public decimal HourRate { get; set; }
        public virtual ICollection<DaySchedule> DaySchedules { get; set; }
        public virtual ICollection<Lesson> Lessons { get; set; }
        public virtual ICollection<Test> Tests { get; set; }
    }
}
