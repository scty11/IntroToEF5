using System;
using System.Collections.Generic;

namespace AdventureworksModel.Models
{
    public partial class TestReport
    {
        public string MajorNotes { get; set; }
        public string MinorNotes { get; set; }
        public System.DateTime Date { get; set; }
        public System.TimeSpan StartTime { get; set; }
        public string Pass { get; set; }
        public string NextLessonNote { get; set; }
        public virtual Test Test { get; set; }
    }
}
