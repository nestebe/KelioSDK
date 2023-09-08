
// Type: KelioSDK.Models.EmployeeLoanedOrBorrowed




using System;
using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "EmployeeLoanedOrBorrowed")]
  public class EmployeeLoanedOrBorrowed : EmployeeInformation
  {
    [XmlElement(DataType = "boolean", ElementName = "plannable", IsNullable = true)]
    public bool? Plannable { get; set; }

    [XmlElement(DataType = "string", ElementName = "comment", IsNullable = true)]
    public string Comment { get; set; }

    [XmlElement(DataType = "date", ElementName = "startDate", IsNullable = true)]
    public DateTime? StartDate { get; set; }

    [XmlElement(DataType = "date", ElementName = "endDate", IsNullable = true)]
    public DateTime? EndDate { get; set; }

    [XmlElement(DataType = "string", ElementName = "borrower", IsNullable = true)]
    public string Borrower { get; set; }

    [XmlElement(DataType = "int", ElementName = "assignmentSectionKey", IsNullable = true)]
    public int? AssignmentSectionKey { get; set; }

    [XmlElement(DataType = "string", ElementName = "assignmentSectionDescription", IsNullable = true)]
    public string AssignmentSectionDescription { get; set; }

    [XmlElement(DataType = "string", ElementName = "assignmentSectionAbbreviation", IsNullable = true)]
    public string AssignmentSectionAbbreviation { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "borrowing", IsNullable = true)]
    public bool? Borrowing { get; set; }
  }
}
