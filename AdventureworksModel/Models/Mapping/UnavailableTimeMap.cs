using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace AdventureworksModel.Models.Mapping
{
    public class UnavailableTimeMap : EntityTypeConfiguration<UnavailableTime>
    {
        public UnavailableTimeMap()
        {
            // Primary Key
            this.HasKey(t => new { t.Date, t.From });

            // Properties
            this.Property(t => t.Note)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("UnavailableTime");
            this.Property(t => t.Date).HasColumnName("Date");
            this.Property(t => t.From).HasColumnName("From");
            this.Property(t => t.To).HasColumnName("To");
            this.Property(t => t.Note).HasColumnName("Note");

            // Relationships
            this.HasRequired(t => t.DaySchedule)
                .WithMany(t => t.UnavailableTimes)
                .HasForeignKey(d => d.Date);

        }
    }
}
