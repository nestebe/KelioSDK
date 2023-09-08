
//.ExportInterfaces




using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportInterfaces")]
  public class ExportInterfaces
  {
    [XmlElement(DataType = "int", ElementName = "typeFilter", IsNullable = true, Order = 0)]
    public int? TypeFilter { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "isStandard", IsNullable = true, Order = 1)]
    public bool? IsStandard { get; set; }
  }
}
