
// Type: KelioSDK.Models.AskedFiling




using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "askedFiling")]
  public class AskedFiling
  {
    [XmlElement(DataType = "int", ElementName = "filingType", IsNullable = true)]
    public int? FilingType { get; set; }
  }
}
