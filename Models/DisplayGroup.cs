
// Type: KelioSDK.Models.DisplayGroup




using KelioSDK.Common;
using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "DisplayGroup")]
  public class DisplayGroup : ObjectBase
  {
    [XmlElement(DataType = "string", ElementName = "displayGroupDescription", IsNullable = true)]
    public string DisplayGroupDescription { get; set; }

    [XmlElement(DataType = "int", ElementName = "displayGroupKey", IsNullable = true)]
    public int? DisplayGroupKey { get; set; }
  }
}
