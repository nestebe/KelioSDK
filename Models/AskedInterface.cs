
// Type: KelioSDK.Models.AskedInterface




using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "AskedInterface")]
  public class AskedInterface
  {
    [XmlElement(DataType = "int", ElementName = "typeFilter", IsNullable = true)]
    public int? TypeFilter { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "isStandard", IsNullable = true)]
    public bool? IsStandard { get; set; }
  }
}
