using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace AdventureworksModel.Models.Mapping
{
    public class DayScheduleMap : EntityTypeConfiguration<DaySchedule>
    {
        public DayScheduleMap()
        {
            // Primary Key
            this.HasKey(t => t.Date);

            // Properties
            this.Property(t => t.InstructorUserName)
                .IsRequired()
                .HasMaxLength(128);

            // Table & Column Mappings
            this.ToTable("DaySchedule");
            this.Property(t => t.Date).HasColumnName("Date");
            this.Property(t => t.InstructorUserName).HasColumnName("InstructorUserName");
            this.Property(t => t.StartTime).HasColumnName("StartTime");
            this.Property(t => t.FinishTime).HasColumnName("FinishTime");

            // Relationships
            this.HasRequired(t => t.Instructor)
                .WithMany(t => t.DaySchedules)
                .HasForeignKey(d => d.InstructorUserName);

        }
    }
}
