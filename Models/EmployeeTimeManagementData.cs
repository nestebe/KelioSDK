
// Type: KelioSDK.Models.EmployeeTimeManagementData




using System;
using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "EmployeeTimeManagementData")]
  public class EmployeeTimeManagementData : EmployeeInformationAndCriterion
  {
    [XmlElement(DataType = "int", ElementName = "currentTimeContractTypeCode", IsNullable = true)]
    public int? CurrentTimeContractTypeCode { get; set; }

    [XmlElement(DataType = "date", ElementName = "toilCalendarAssignmentEndDate", IsNullable = true)]
    public DateTime? ToilCalendarAssignmentEndDate { get; set; }

    [XmlElement(DataType = "date", ElementName = "currentOvertimeRuleApplicationDate", IsNullable = true)]
    public DateTime? CurrentOvertimeRuleApplicationDate { get; set; }

    [XmlElement(DataType = "date", ElementName = "currentClassOfCheckApplicationEndDate", IsNullable = true)]
    public DateTime? CurrentClassOfCheckApplicationEndDate { get; set; }

    [XmlElement(DataType = "string", ElementName = "currentShiftSchedulerDescription", IsNullable = true)]
    public string CurrentShiftSchedulerDescription { get; set; }

    [XmlElement(DataType = "string", ElementName = "currentEndOfPeriodCalendarDescription", IsNullable = true)]
    public string CurrentEndOfPeriodCalendarDescription { get; set; }

    [XmlElement(DataType = "string", ElementName = "toilCalendarAbbreviation", IsNullable = true)]
    public string ToilCalendarAbbreviation { get; set; }

    [XmlElement(DataType = "string", ElementName = "toilCalendarDescription", IsNullable = true)]
    public string ToilCalendarDescription { get; set; }

    [XmlElement(DataType = "date", ElementName = "toilCalendarAssignmentStartDate", IsNullable = true)]
    public DateTime? ToilCalendarAssignmentStartDate { get; set; }

    [XmlElement(DataType = "string", ElementName = "attachedDocument", IsNullable = true)]
    public string AttachedDocument { get; set; }

    [XmlElement(DataType = "date", ElementName = "currentPublicHolidayCalendarApplicationDate", IsNullable = true)]
    public DateTime? CurrentPublicHolidayCalendarApplicationDate { get; set; }

    [XmlElement(DataType = "date", ElementName = "currentClassOfCheckApplicationDate", IsNullable = true)]
    public DateTime? CurrentClassOfCheckApplicationDate { get; set; }

    [XmlElement(DataType = "date", ElementName = "currentEndOfPeriodCalendarApplicationDate", IsNullable = true)]
    public DateTime? CurrentEndOfPeriodCalendarApplicationDate { get; set; }

    [XmlElement(DataType = "date", ElementName = "currentScheduleApplicationDate", IsNullable = true)]
    public DateTime? CurrentScheduleApplicationDate { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "flexileaveAbsenceAllowance", IsNullable = true)]
    public bool? FlexileaveAbsenceAllowance { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "automaticAbsenceAllowance", IsNullable = true)]
    public bool? AutomaticAbsenceAllowance { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "automaticClockingOutAllowance", IsNullable = true)]
    public bool? AutomaticClockingOutAllowance { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "compensatoryLeaveAllowance", IsNullable = true)]
    public bool? CompensatoryLeaveAllowance { get; set; }

    [XmlElement(DataType = "string", ElementName = "currentScheduleAbbreviation", IsNullable = true)]
    public string CurrentScheduleAbbreviation { get; set; }

    [XmlElement(DataType = "string", ElementName = "currentScheduleDescription", IsNullable = true)]
    public string CurrentScheduleDescription { get; set; }

    [XmlElement(DataType = "string", ElementName = "hourlyContractAbbreviation", IsNullable = true)]
    public string HourlyContractAbbreviation { get; set; }

    [XmlElement(DataType = "string", ElementName = "hourlyContractDescription", IsNullable = true)]
    public string HourlyContractDescription { get; set; }

    [XmlElement(DataType = "double", ElementName = "currentTimeContractValue", IsNullable = true)]
    public double? CurrentTimeContractValue { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "resetResult", IsNullable = true)]
    public bool? ResetResult { get; set; }

    [XmlElement(DataType = "int", ElementName = "userProfileAssignmentWizardKey", IsNullable = true)]
    public int? UserProfileAssignmentWizardKey { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "closeExceptionalAssignments", IsNullable = true)]
    public bool? CloseExceptionalAssignments { get; set; }

    [XmlElement(DataType = "string", ElementName = "currentCalculationConfigurationDescription", IsNullable = true)]
    public string CurrentCalculationConfigurationDescription { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "closePreviousTakenIntoAccountPeriod", IsNullable = true)]
    public bool? ClosePreviousTakenIntoAccountPeriod { get; set; }

    [XmlElement(DataType = "string", ElementName = "currentClassOfCheckDescription", IsNullable = true)]
    public string CurrentClassOfCheckDescription { get; set; }

    [XmlElement(DataType = "string", ElementName = "currentPublicHolidayCalendarDescription", IsNullable = true)]
    public string CurrentPublicHolidayCalendarDescription { get; set; }

    [XmlElement(DataType = "date", ElementName = "currentCalculationConfigurationApplicationDate", IsNullable = true)]
    public DateTime? CurrentCalculationConfigurationApplicationDate { get; set; }

    [XmlElement(DataType = "string", ElementName = "userProfileAssignmentWizardDescription", IsNullable = true)]
    public string UserProfileAssignmentWizardDescription { get; set; }

    [XmlElement(DataType = "date", ElementName = "currentOvertimeRuleEndDate", IsNullable = true)]
    public DateTime? CurrentOvertimeRuleEndDate { get; set; }

    [XmlElement(DataType = "date", ElementName = "authorisedFunctionAssignmentEndDate", IsNullable = true)]
    public DateTime? AuthorisedFunctionAssignmentEndDate { get; set; }

    [XmlElement(DataType = "date", ElementName = "authorisedFunctionAssignmentStartDate", IsNullable = true)]
    public DateTime? AuthorisedFunctionAssignmentStartDate { get; set; }

    [XmlElement(DataType = "string", ElementName = "currentOvertimeRule", IsNullable = true)]
    public string CurrentOvertimeRule { get; set; }
  }
}
