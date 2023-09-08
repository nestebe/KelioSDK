
// Type: KelioSDK.Models.SimpleEmployeeGroup




using KelioSDK.Common;
using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "SimpleEmployeeGroup")]
  public class SimpleEmployeeGroup : ObjectBase
  {
    [XmlElement(DataType = "int", ElementName = "employeeGroupKey", IsNullable = true)]
    public int? EmployeeGroupKey { get; set; }

    [XmlElement(DataType = "string", ElementName = "employeeGroupDescription", IsNullable = true)]
    public string EmployeeGroupDescription { get; set; }
  }
}
