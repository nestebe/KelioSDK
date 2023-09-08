
// Type: KelioSDK.Models.EmployeeJobAssignment




using System;
using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "EmployeeJobAssignment")]
  public class EmployeeJobAssignment : EmployeeInformation
  {
    [XmlElement(DataType = "date", ElementName = "assignmentEndDate", IsNullable = true)]
    public DateTime? AssignmentEndDate { get; set; }

    [XmlElement(DataType = "date", ElementName = "assignmentDate", IsNullable = true)]
    public DateTime? AssignmentDate { get; set; }

    [XmlElement(DataType = "int", ElementName = "employeeJobAssignmentKey", IsNullable = true)]
    public int? EmployeeJobAssignmentKey { get; set; }

    [XmlElement(DataType = "int", ElementName = "employeeJobKey", IsNullable = true)]
    public int? EmployeeJobKey { get; set; }

    [XmlElement(DataType = "string", ElementName = "employeeJobDescription", IsNullable = true)]
    public string EmployeeJobDescription { get; set; }

    [XmlElement(DataType = "string", ElementName = "employeeJobAbbreviation", IsNullable = true)]
    public string EmployeeJobAbbreviation { get; set; }
  }
}
