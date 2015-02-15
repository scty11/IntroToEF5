using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace AdventureworksModel.Models.Mapping
{
    public class PupilMap : EntityTypeConfiguration<Pupil>
    {
        public PupilMap()
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

            this.Property(t => t.PickUpAddress)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.EmailAddress)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.ContactNo)
                .HasMaxLength(11);

            this.Property(t => t.IsStudent)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Postcode)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(8);

            // Table & Column Mappings
            this.ToTable("Pupil");
            this.Property(t => t.UserName).HasColumnName("UserName");
            this.Property(t => t.FirstName).HasColumnName("FirstName");
            this.Property(t => t.LastName).HasColumnName("LastName");
            this.Property(t => t.PickUpAddress).HasColumnName("PickUpAddress");
            this.Property(t => t.EmailAddress).HasColumnName("EmailAddress");
            this.Property(t => t.ContactNo).HasColumnName("ContactNo");
            this.Property(t => t.IsStudent).HasColumnName("IsStudent");
            this.Property(t => t.Postcode).HasColumnName("Postcode");
        }
    }
}
