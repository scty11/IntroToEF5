using System;
using System.Collections.Generic;

namespace AdventureworksModel.Models
{
    public partial class Test
    {
        public System.DateTime Date { get; set; }
        public System.TimeSpan StartTime { get; set; }
        public System.TimeSpan EndTime { get; set; }
        public decimal Price { get; set; }
        public string PickUpAddress { get; set; }
        public string DropOffAddress { get; set; }
        public string PupilUserName { get; set; }
        public string InstructorUserName { get; set; }
        public string DropOffPostcode { get; set; }
        public string PickUpPostcode { get; set; }
        public virtual DaySchedule DaySchedule { get; set; }
        public virtual Instructor Instructor { get; set; }
        public virtual Pupil Pupil { get; set; }
        public virtual TestReport TestReport { get; set; }
    }
}
