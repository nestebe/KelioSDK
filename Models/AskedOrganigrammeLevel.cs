
// Type: KelioSDK.Models.AskedOrganigrammeLevel




using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "AskedOrganigrammeLevel")]
  public class AskedOrganigrammeLevel
  {
    [XmlElement(DataType = "short", ElementName = "levelFilter", IsNullable = true)]
    public short? LevelFilter { get; set; }
  }
}
