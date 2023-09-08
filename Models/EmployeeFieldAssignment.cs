
// Type: KelioSDK.Models.EmployeeFieldAssignment




using System;
using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "EmployeeFieldAssignment")]
  public class EmployeeFieldAssignment : EmployeeInformation
  {
    [XmlElement(DataType = "string", ElementName = "employeeFieldDataAbbreviation", IsNullable = true)]
    public string EmployeeFieldDataAbbreviation { get; set; }

    [XmlElement(DataType = "string", ElementName = "employeeFieldValue", IsNullable = true)]
    public string EmployeeFieldValue { get; set; }

    [XmlElement(DataType = "int", ElementName = "employeeFieldKey", IsNullable = true)]
    public int? EmployeeFieldKey { get; set; }

    [XmlElement(DataType = "date", ElementName = "startDate", IsNullable = true)]
    public DateTime? StartDate { get; set; }

    [XmlElement(DataType = "date", ElementName = "endDate", IsNullable = true)]
    public DateTime? EndDate { get; set; }

    [XmlElement(DataType = "string", ElementName = "employeeFieldAbbreviation", IsNullable = true)]
    public string EmployeeFieldAbbreviation { get; set; }

    [XmlElement(DataType = "string", ElementName = "employeeFieldDescription", IsNullable = true)]
    public string EmployeeFieldDescription { get; set; }
  }
}
