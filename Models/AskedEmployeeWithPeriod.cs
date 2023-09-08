
// Type: KelioSDK.Models.AskedEmployeeWithPeriod




using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "askedEmployeeWithPeriod")]
  public class AskedEmployeeWithPeriod : EmployeeInformation
  {
    [XmlElement(DataType = "int", ElementName = "offset", IsNullable = true)]
    public int? Offset { get; set; }
  }
}
