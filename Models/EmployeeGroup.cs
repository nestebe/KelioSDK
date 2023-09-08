
// Type: KelioSDK.Models.EmployeeGroup




using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "EmployeeGroup")]
  public class EmployeeGroup : EmployeeInformation
  {
    [XmlElement(DataType = "int", ElementName = "employeeGroupKey", IsNullable = true)]
    public int? EmployeeGroupKey { get; set; }

    [XmlElement(DataType = "string", ElementName = "employeeGroupDescription", IsNullable = true)]
    public string EmployeeGroupDescription { get; set; }
  }
}
