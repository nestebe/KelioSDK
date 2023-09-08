
// Type: KelioSDK.Models.AccountType




using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "AccountType")]
  public class AccountType : Type
  {
    [XmlElement(DataType = "short", ElementName = "unit", IsNullable = true)]
    public short? Unit { get; set; }
  }
}
