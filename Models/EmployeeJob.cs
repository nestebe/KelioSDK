
// Type: KelioSDK.Models.EmployeeJob




using KelioSDK.Common;
using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "EmployeeJob")]
  public class EmployeeJob : ObjectBase
  {
    [XmlElement(DataType = "boolean", ElementName = "searchEmployeeJobUsingAbbreviation", IsNullable = true)]
    public bool? SearchEmployeeJobUsingAbbreviation { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "searchEmployeeJobUsingDescription", IsNullable = true)]
    public bool? SearchEmployeeJobUsingDescription { get; set; }

    [XmlElement(DataType = "int", ElementName = "employeeJobKey", IsNullable = true)]
    public int? EmployeeJobKey { get; set; }

    [XmlElement(DataType = "string", ElementName = "employeeJobDescription", IsNullable = true)]
    public string EmployeeJobDescription { get; set; }

    [XmlElement(DataType = "string", ElementName = "employeeJobAbbreviation", IsNullable = true)]
    public string EmployeeJobAbbreviation { get; set; }
  }
}
