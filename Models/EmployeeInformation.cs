
// Type: KelioSDK.Models.EmployeeInformation




using KelioSDK.Common;
using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "EmployeeInformation")]
  public class EmployeeInformation : ObjectBase
  {
    [XmlElement(DataType = "string", ElementName = "employeeIdentificationCode", IsNullable = true)]
    public string EmployeeIdentificationCode { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "archivedEmployee", IsNullable = true)]
    public bool? ArchivedEmployee { get; set; }

    [XmlElement(DataType = "string", ElementName = "employeeBadgeCode", IsNullable = true)]
    public string EmployeeBadgeCode { get; set; }

    [XmlElement(DataType = "string", ElementName = "employeeIdentificationNumber", IsNullable = true)]
    public string EmployeeIdentificationNumber { get; set; }

    [XmlElement(DataType = "int", ElementName = "employeeKey", IsNullable = true)]
    public int? EmployeeKey { get; set; }

    [XmlElement(DataType = "string", ElementName = "employeeSurname", IsNullable = true)]
    public string EmployeeSurname { get; set; }

    [XmlElement(DataType = "string", ElementName = "employeeFirstName", IsNullable = true)]
    public string EmployeeFirstName { get; set; }
  }
}
