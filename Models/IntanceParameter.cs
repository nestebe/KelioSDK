
// Type: KelioSDK.Models.IntanceParameter




using KelioSDK.Common;
using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "IntanceParameter")]
  public class IntanceParameter : ObjectBase
  {
    [XmlElement(DataType = "string", ElementName = "parameterValue", IsNullable = true)]
    public string ParameterValue { get; set; }

    [XmlElement(DataType = "string", ElementName = "parameterKey", IsNullable = true)]
    public string ParameterKey { get; set; }
  }
}
