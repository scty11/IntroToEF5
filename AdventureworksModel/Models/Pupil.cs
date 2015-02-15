using System;
using System.Collections.Generic;

namespace AdventureworksModel.Models
{
    public partial class Pupil
    {
        public Pupil()
        {
            this.Lessons = new List<Lesson>();
            this.Tests = new List<Test>();
        }

        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PickUpAddress { get; set; }
        public string EmailAddress { get; set; }
        public string ContactNo { get; set; }
        public string IsStudent { get; set; }
        public string Postcode { get; set; }
        public virtual ICollection<Lesson> Lessons { get; set; }
        public virtual ICollection<Test> Tests { get; set; }
    }
}
