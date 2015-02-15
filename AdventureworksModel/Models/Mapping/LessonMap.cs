using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace AdventureworksModel.Models.Mapping
{
    public class LessonMap : EntityTypeConfiguration<Lesson>
    {
        public LessonMap()
        {
            // Primary Key
            this.HasKey(t => new { t.Date, t.StartTime });

            // Properties
            this.Property(t => t.PickUpAddress)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.DropOffAddress)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Creator)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.PupilUserName)
                .IsRequired()
                .HasMaxLength(128);

            this.Property(t => t.InstructorUserName)
                .IsRequired()
                .HasMaxLength(128);

            this.Property(t => t.DropOffPostcode)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.PickUpPostcode)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(8);

            // Table & Column Mappings
            this.ToTable("Lesson");
            this.Property(t => t.Date).HasColumnName("Date");
            this.Property(t => t.StartTime).HasColumnName("StartTime");
            this.Property(t => t.EndTime).HasColumnName("EndTime");
            this.Property(t => t.Price).HasColumnName("Price");
            this.Property(t => t.PickUpAddress).HasColumnName("PickUpAddress");
            this.Property(t => t.DropOffAddress).HasColumnName("DropOffAddress");
            this.Property(t => t.Creator).HasColumnName("Creator");
            this.Property(t => t.PupilUserName).HasColumnName("PupilUserName");
            this.Property(t => t.InstructorUserName).HasColumnName("InstructorUserName");
            this.Property(t => t.DropOffPostcode).HasColumnName("DropOffPostcode");
            this.Property(t => t.PickUpPostcode).HasColumnName("PickUpPostcode");

            // Relationships
            this.HasRequired(t => t.DaySchedule)
                .WithMany(t => t.Lessons)
                .HasForeignKey(d => d.Date);
            this.HasRequired(t => t.Instructor)
                .WithMany(t => t.Lessons)
                .HasForeignKey(d => d.InstructorUserName);
            this.HasRequired(t => t.LessonReport)
                .WithOptional(t => t.Lesson);
            this.HasRequired(t => t.Pupil)
                .WithMany(t => t.Lessons)
                .HasForeignKey(d => d.PupilUserName);

        }
    }
}
