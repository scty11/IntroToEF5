using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using AdventureworksModel.Models.Mapping;

namespace AdventureworksModel.Models
{
    public partial class ProjectDatabaseContext : DbContext
    {
        static ProjectDatabaseContext()
        {
            Database.SetInitializer<ProjectDatabaseContext>(null);
        }

        public ProjectDatabaseContext()
            : base("Name=ProjectDatabaseContext")
        {
        }

        public DbSet<AddressDetail> AddressDetails { get; set; }
        public DbSet<AspNetRole> AspNetRoles { get; set; }
        public DbSet<AspNetUserClaim> AspNetUserClaims { get; set; }
        public DbSet<AspNetUserLogin> AspNetUserLogins { get; set; }
        public DbSet<AspNetUser> AspNetUsers { get; set; }
        public DbSet<DaySchedule> DaySchedules { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Lesson> Lessons { get; set; }
        public DbSet<LessonReport> LessonReports { get; set; }
        public DbSet<Pupil> Pupils { get; set; }
        public DbSet<sysdiagram> sysdiagrams { get; set; }
        public DbSet<Test> Tests { get; set; }
        public DbSet<TestReport> TestReports { get; set; }
        public DbSet<Timeslot> Timeslots { get; set; }
        public DbSet<UnavailableTime> UnavailableTimes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AddressDetailMap());
            modelBuilder.Configurations.Add(new AspNetRoleMap());
            modelBuilder.Configurations.Add(new AspNetUserClaimMap());
            modelBuilder.Configurations.Add(new AspNetUserLoginMap());
            modelBuilder.Configurations.Add(new AspNetUserMap());
            modelBuilder.Configurations.Add(new DayScheduleMap());
            modelBuilder.Configurations.Add(new InstructorMap());
            modelBuilder.Configurations.Add(new LessonMap());
            modelBuilder.Configurations.Add(new LessonReportMap());
            modelBuilder.Configurations.Add(new PupilMap());
            modelBuilder.Configurations.Add(new sysdiagramMap());
            modelBuilder.Configurations.Add(new TestMap());
            modelBuilder.Configurations.Add(new TestReportMap());
            modelBuilder.Configurations.Add(new TimeslotMap());
            modelBuilder.Configurations.Add(new UnavailableTimeMap());
        }
    }
}
