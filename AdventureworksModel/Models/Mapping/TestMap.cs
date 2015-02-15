using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace AdventureworksModel.Models.Mapping
{
    public class TestMap : EntityTypeConfiguration<Test>
    {
        public TestMap()
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
            this.ToTable("Test");
            this.Property(t => t.Date).HasColumnName("Date");
            this.Property(t => t.StartTime).HasColumnName("StartTime");
            this.Property(t => t.EndTime).HasColumnName("EndTime");
            this.Property(t => t.Price).HasColumnName("Price");
            this.Property(t => t.PickUpAddress).HasColumnName("PickUpAddress");
            this.Property(t => t.DropOffAddress).HasColumnName("DropOffAddress");
            this.Property(t => t.PupilUserName).HasColumnName("PupilUserName");
            this.Property(t => t.InstructorUserName).HasColumnName("InstructorUserName");
            this.Property(t => t.DropOffPostcode).HasColumnName("DropOffPostcode");
            this.Property(t => t.PickUpPostcode).HasColumnName("PickUpPostcode");

            // Relationships
            this.HasRequired(t => t.DaySchedule)
                .WithMany(t => t.Tests)
                .HasForeignKey(d => d.Date);
            this.HasRequired(t => t.Instructor)
                .WithMany(t => t.Tests)
                .HasForeignKey(d => d.InstructorUserName);
            this.HasRequired(t => t.Pupil)
                .WithMany(t => t.Tests)
                .HasForeignKey(d => d.PupilUserName);
            this.HasRequired(t => t.TestReport)
                .WithOptional(t => t.Test);

        }
    }
}
