using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace AdventureworksModel.Models.Mapping
{
    public class TestReportMap : EntityTypeConfiguration<TestReport>
    {
        public TestReportMap()
        {
            // Primary Key
            this.HasKey(t => new { t.Date, t.StartTime });

            // Properties
            this.Property(t => t.Pass)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(4);

            // Table & Column Mappings
            this.ToTable("TestReport");
            this.Property(t => t.MajorNotes).HasColumnName("MajorNotes");
            this.Property(t => t.MinorNotes).HasColumnName("MinorNotes");
            this.Property(t => t.Date).HasColumnName("Date");
            this.Property(t => t.StartTime).HasColumnName("StartTime");
            this.Property(t => t.Pass).HasColumnName("Pass");
            this.Property(t => t.NextLessonNote).HasColumnName("NextLessonNote");
        }
    }
}
