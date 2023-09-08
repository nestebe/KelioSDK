
// Type: KelioSDK.Models.Icon




using KelioSDK.Common;
using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "Icon")]
  public class Icon : ObjectBase
  {
    [XmlElement(DataType = "string", ElementName = "name", IsNullable = true)]
    public string Name { get; set; }

    [XmlElement(DataType = "int", ElementName = "iconKey", IsNullable = true)]
    public int? IconKey { get; set; }
  }
}
