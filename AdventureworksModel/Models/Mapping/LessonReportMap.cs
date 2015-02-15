using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace AdventureworksModel.Models.Mapping
{
    public class LessonReportMap : EntityTypeConfiguration<LessonReport>
    {
        public LessonReportMap()
        {
            // Primary Key
            this.HasKey(t => new { t.Date, t.StartTime });

            // Properties
            // Table & Column Mappings
            this.ToTable("LessonReport");
            this.Property(t => t.Date).HasColumnName("Date");
            this.Property(t => t.ProblemNote).HasColumnName("ProblemNote");
            this.Property(t => t.NextLessonNote).HasColumnName("NextLessonNote");
            this.Property(t => t.StartTime).HasColumnName("StartTime");
            this.Property(t => t.BayScore).HasColumnName("BayScore");
            this.Property(t => t.ParallelScore).HasColumnName("ParallelScore");
            this.Property(t => t.ReverseCornerScore).HasColumnName("ReverseCornerScore");
            this.Property(t => t.TurnScore).HasColumnName("TurnScore");
        }
    }
}
