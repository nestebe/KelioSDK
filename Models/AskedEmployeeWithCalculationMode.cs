
// Type: KelioSDK.Models.AskedEmployeeWithCalculationMode




using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "askedEmployeeWithCalculationMode")]
  public class AskedEmployeeWithCalculationMode : AskedEmployee
  {
    [XmlElement(DataType = "short", ElementName = "calculationMode", IsNullable = true)]
    public short? CalculationMode { get; set; }
  }
}
