
// Type: KelioSDK.Models.CalculationFunctionFilter




using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "CalculationFunctionFilter")]
  public class CalculationFunctionFilter : AccountFilter
  {
    [XmlElement(DataType = "short", ElementName = "functionType", IsNullable = true)]
    public short? FunctionType { get; set; }
  }
}
