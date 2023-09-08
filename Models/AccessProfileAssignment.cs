
// Type: KelioSDK.Models.AccessProfileAssignment




using System;
using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "AccessProfileAssignment")]
  public class AccessProfileAssignment : EmployeeInformation
  {
    [XmlElement(DataType = "string", ElementName = "accessProfileSiteDescription", IsNullable = true)]
    public string AccessProfileSiteDescription { get; set; }

    [XmlElement(DataType = "date", ElementName = "assignmentEndDate", IsNullable = true)]
    public DateTime? AssignmentEndDate { get; set; }

    [XmlElement(DataType = "int", ElementName = "accessProfileKey", IsNullable = true)]
    public int? AccessProfileKey { get; set; }

    [XmlElement(DataType = "string", ElementName = "accessProfileDescription", IsNullable = true)]
    public string AccessProfileDescription { get; set; }

    [XmlElement(DataType = "date", ElementName = "assignmentStartDate", IsNullable = true)]
    public DateTime? AssignmentStartDate { get; set; }
  }
}
