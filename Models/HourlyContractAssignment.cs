
// Type: KelioSDK.Models.HourlyContractAssignment




using System;
using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "HourlyContractAssignment")]
  public class HourlyContractAssignment : EmployeeInformation
  {
    [XmlElement(DataType = "string", ElementName = "hourlyContractAssignmentInformation", IsNullable = true)]
    public string HourlyContractAssignmentInformation { get; set; }

    [XmlElement(DataType = "date", ElementName = "hourlyContractAssignmentStartDate", IsNullable = true)]
    public DateTime? HourlyContractAssignmentStartDate { get; set; }

    [XmlElement(DataType = "date", ElementName = "hourlyContractAssignmentEndDate", IsNullable = true)]
    public DateTime? HourlyContractAssignmentEndDate { get; set; }

    [XmlElement(DataType = "string", ElementName = "hourlyContractAbbreviation", IsNullable = true)]
    public string HourlyContractAbbreviation { get; set; }

    [XmlElement(DataType = "string", ElementName = "hourlyContractDescription", IsNullable = true)]
    public string HourlyContractDescription { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "resetResult", IsNullable = true)]
    public bool? ResetResult { get; set; }

    [XmlElement(DataType = "int", ElementName = "userProfileAssignmentWizardKey", IsNullable = true)]
    public int? UserProfileAssignmentWizardKey { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "closeExceptionalAssignments", IsNullable = true)]
    public bool? CloseExceptionalAssignments { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "closePreviousTakenIntoAccountPeriod", IsNullable = true)]
    public bool? ClosePreviousTakenIntoAccountPeriod { get; set; }

    [XmlElement(DataType = "string", ElementName = "userProfileAssignmentWizardDescription", IsNullable = true)]
    public string UserProfileAssignmentWizardDescription { get; set; }
  }
}
