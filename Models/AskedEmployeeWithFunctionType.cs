
// Type: KelioSDK.Models.AskedEmployeeWithFunctionType




using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "askedEmployeeWithFunctionType")]
  public class AskedEmployeeWithFunctionType : AskedEmployee
  {
    [XmlElement(DataType = "short", ElementName = "functionType", IsNullable = true)]
    public short? FunctionType { get; set; }
  }
}
