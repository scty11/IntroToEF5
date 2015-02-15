using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace AdventureworksModel.Models.Mapping
{
    public class InstructorMap : EntityTypeConfiguration<Instructor>
    {
        public InstructorMap()
        {
            // Primary Key
            this.HasKey(t => t.UserName);

            // Properties
            this.Property(t => t.UserName)
                .IsRequired()
                .HasMaxLength(128);

            this.Property(t => t.FirstName)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.LastName)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.EmailAddress)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.ContactNo)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.EDINumber)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(6);

            // Table & Column Mappings
            this.ToTable("Instructor");
            this.Property(t => t.UserName).HasColumnName("UserName");
            this.Property(t => t.FirstName).HasColumnName("FirstName");
            this.Property(t => t.LastName).HasColumnName("LastName");
            this.Property(t => t.EmailAddress).HasColumnName("EmailAddress");
            this.Property(t => t.ContactNo).HasColumnName("ContactNo");
            this.Property(t => t.EDINumber).HasColumnName("EDINumber");
            this.Property(t => t.HourRate).HasColumnName("HourRate");
        }
    }
}
