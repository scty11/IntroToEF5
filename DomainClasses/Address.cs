using SalesModel.DomainClasses.Enums;

namespace SalesModel.DomainClasses
{
  public class Address
  {
    public int AddressId { get; set; }
    public string Street { get; set; }
    public string City { get; set; }
    public string StateProvince { get; set; }
    public string PostalCode { get; set; }
    public AddressType AddressType { get; set; }
    public int CustomerId { get; set; }

    public virtual Customer Customer { get; set; }
  }
} 