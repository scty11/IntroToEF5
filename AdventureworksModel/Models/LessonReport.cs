using System;
using System.Collections.Generic;

namespace AdventureworksModel.Models
{
    public partial class LessonReport
    {
        public System.DateTime Date { get; set; }
        public string ProblemNote { get; set; }
        public string NextLessonNote { get; set; }
        public System.TimeSpan StartTime { get; set; }
        public int BayScore { get; set; }
        public int ParallelScore { get; set; }
        public int ReverseCornerScore { get; set; }
        public int TurnScore { get; set; }
        public virtual Lesson Lesson { get; set; }
    }
}
