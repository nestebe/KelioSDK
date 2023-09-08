
// Type: KelioSDK.Models.TakenIntoAccountPeriod




using System;
using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "TakenIntoAccountPeriod")]
  public class TakenIntoAccountPeriod : EmployeeInformation
  {
    [XmlElement(DataType = "int", ElementName = "takenIntoAccountPeriodKey", IsNullable = true)]
    public int? TakenIntoAccountPeriodKey { get; set; }

    [XmlElement(DataType = "string", ElementName = "comment", IsNullable = true)]
    public string Comment { get; set; }

    [XmlElement(DataType = "date", ElementName = "startDate", IsNullable = true)]
    public DateTime? StartDate { get; set; }

    [XmlElement(DataType = "date", ElementName = "endDate", IsNullable = true)]
    public DateTime? EndDate { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "closePreviousSectionAssignments", IsNullable = true)]
    public bool? ClosePreviousSectionAssignments { get; set; }

    [XmlElement(DataType = "string", ElementName = "ReasonForLeavingDescription", IsNullable = true)]
    public string ReasonForLeavingDescription { get; set; }

    [XmlElement(DataType = "string", ElementName = "hourlyContractAbbreviation", IsNullable = true)]
    public string HourlyContractAbbreviation { get; set; }

    [XmlElement(DataType = "string", ElementName = "hourlyContractDescription", IsNullable = true)]
    public string HourlyContractDescription { get; set; }

    [XmlElement(DataType = "string", ElementName = "ReasonForLeavingCode", IsNullable = true)]
    public string ReasonForLeavingCode { get; set; }

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
