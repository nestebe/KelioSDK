
// Type: KelioSDK.Models.AskedWindowWithType




using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "askedWindowWithType")]
  public class AskedWindowWithType : AskedWindow
  {
    [XmlElement(DataType = "int", ElementName = "windowType", IsNullable = true)]
    public int? WindowType { get; set; }
  }
}
