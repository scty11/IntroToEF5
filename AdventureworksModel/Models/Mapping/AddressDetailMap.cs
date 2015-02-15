using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace AdventureworksModel.Models.Mapping
{
    public class AddressDetailMap : EntityTypeConfiguration<AddressDetail>
    {
        public AddressDetailMap()
        {
            // Primary Key
            this.HasKey(t => t.Address);

            // Properties
            this.Property(t => t.Address)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Postcode)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(8);

            // Table & Column Mappings
            this.ToTable("AddressDetails");
            this.Property(t => t.Address).HasColumnName("Address");
            this.Property(t => t.Postcode).HasColumnName("Postcode");
        }
    }
}
