
// Type: KelioSDK.Models.AskedEmployeeWithRelativeDatesAndFunctionType




using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "askedEmployeeWithRelativeDatesAndFunctionType")]
  public class AskedEmployeeWithRelativeDatesAndFunctionType : AskedEmployeeWithRelativeDates
  {
    [XmlElement(DataType = "short", ElementName = "functionType", IsNullable = true)]
    public short? FunctionType { get; set; }
  }
}
