
// Type: KelioSDK.Models.Entity




using KelioSDK.Common;
using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "entity")]
  public class Entity : ObjectBase
  {
    [XmlElement(DataType = "int", ElementName = "entityKey", IsNullable = true)]
    public int? EntityKey { get; set; }

    [XmlElement(DataType = "string", ElementName = "entityDescription", IsNullable = true)]
    public string EntityDescription { get; set; }

    [XmlElement(DataType = "string", ElementName = "entityComment", IsNullable = true)]
    public string EntityComment { get; set; }
  }
}
