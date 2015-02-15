using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace AdventureworksModel.Models.Mapping
{
    public class TimeslotMap : EntityTypeConfiguration<Timeslot>
    {
        public TimeslotMap()
        {
            // Primary Key
            this.HasKey(t => new { t.Date, t.Time });

            // Properties
            this.Property(t => t.Free)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("Timeslot");
            this.Property(t => t.Date).HasColumnName("Date");
            this.Property(t => t.Time).HasColumnName("Time");
            this.Property(t => t.Free).HasColumnName("Free");

            // Relationships
            this.HasRequired(t => t.DaySchedule)
                .WithMany(t => t.Timeslots)
                .HasForeignKey(d => d.Date);

        }
    }
}
