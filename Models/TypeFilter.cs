
// Type: KelioSDK.Models.TypeFilter




using KelioSDK.Common;
using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "TypeFilter")]
  public class TypeFilter : ObjectBase
  {
    [XmlElement(DataType = "short", ElementName = "accountType", IsNullable = true)]
    public short? AccountType { get; set; }
  }
}
