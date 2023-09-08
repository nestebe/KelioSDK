
// Type: KelioSDK.Models.HourlyContract




using KelioSDK.Common;
using System;
using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "HourlyContract")]
  public class HourlyContract : ObjectBase
  {
    [XmlElement(DataType = "date", ElementName = "toilCalendarAssignmentEndDate", IsNullable = true)]
    public DateTime? ToilCalendarAssignmentEndDate { get; set; }

    [XmlElement(DataType = "date", ElementName = "checkProgrammeAssignmentStartDate", IsNullable = true)]
    public DateTime? CheckProgrammeAssignmentStartDate { get; set; }

    [XmlElement(DataType = "date", ElementName = "calculationConfigurationStartDate", IsNullable = true)]
    public DateTime? CalculationConfigurationStartDate { get; set; }

    [XmlElement(DataType = "string", ElementName = "endOfPeriodCalendarDescription", IsNullable = true)]
    public string EndOfPeriodCalendarDescription { get; set; }

    [XmlElement(DataType = "date", ElementName = "periodicOvertimeHourAssignmentStartDate", IsNullable = true)]
    public DateTime? PeriodicOvertimeHourAssignmentStartDate { get; set; }

    [XmlElement(DataType = "date", ElementName = "endOfPeriodCalendarStartDate", IsNullable = true)]
    public DateTime? EndOfPeriodCalendarStartDate { get; set; }

    [XmlElement(DataType = "string", ElementName = "periodicOvertimeHourDescription", IsNullable = true)]
    public string PeriodicOvertimeHourDescription { get; set; }

    [XmlElement(DataType = "string", ElementName = "hourlyContractInformation", IsNullable = true)]
    public string HourlyContractInformation { get; set; }

    [XmlElement(DataType = "string", ElementName = "calculationConfigurationDescription", IsNullable = true)]
    public string CalculationConfigurationDescription { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "exitWithoutClockingAuthorisedFunction", IsNullable = true)]
    public bool? ExitWithoutClockingAuthorisedFunction { get; set; }

    [XmlElement(DataType = "string", ElementName = "checkProgrammeDescription", IsNullable = true)]
    public string CheckProgrammeDescription { get; set; }

    [XmlElement(DataType = "string", ElementName = "hourlyBasisDistributionAbbreviation", IsNullable = true)]
    public string HourlyBasisDistributionAbbreviation { get; set; }

    [XmlElement(DataType = "string", ElementName = "hourlyBasisDistributionDescription", IsNullable = true)]
    public string HourlyBasisDistributionDescription { get; set; }

    [XmlElement(DataType = "string", ElementName = "toilCalendarAbbreviation", IsNullable = true)]
    public string ToilCalendarAbbreviation { get; set; }

    [XmlElement(DataType = "string", ElementName = "toilCalendarDescription", IsNullable = true)]
    public string ToilCalendarDescription { get; set; }

    [XmlElement(DataType = "date", ElementName = "toilCalendarAssignmentStartDate", IsNullable = true)]
    public DateTime? ToilCalendarAssignmentStartDate { get; set; }

    [XmlElement(DataType = "double", ElementName = "hourlyBasis", IsNullable = true)]
    public double? HourlyBasis { get; set; }

    [XmlElement(DataType = "string", ElementName = "authorisedOvertimeHoursAccountAbbreviation", IsNullable = true)]
    public string AuthorisedOvertimeHoursAccountAbbreviation { get; set; }

    [XmlElement(DataType = "int", ElementName = "hourlyContractKey", IsNullable = true)]
    public int? HourlyContractKey { get; set; }

    [XmlElement(DataType = "string", ElementName = "hourlyContractAbbreviation", IsNullable = true)]
    public string HourlyContractAbbreviation { get; set; }

    [XmlElement(DataType = "string", ElementName = "hourlyContractDescription", IsNullable = true)]
    public string HourlyContractDescription { get; set; }

    [XmlElement(DataType = "string", ElementName = "workCycleAbbreviation", IsNullable = true)]
    public string WorkCycleAbbreviation { get; set; }

    [XmlElement(DataType = "date", ElementName = "authorisedAccountAssignmentStartDate", IsNullable = true)]
    public DateTime? AuthorisedAccountAssignmentStartDate { get; set; }

    [XmlElement(DataType = "string", ElementName = "authorisedBonusAccountAbbreviation", IsNullable = true)]
    public string AuthorisedBonusAccountAbbreviation { get; set; }

    [XmlElement(DataType = "string", ElementName = "authorisedOvertimeHoursAccountDescription", IsNullable = true)]
    public string AuthorisedOvertimeHoursAccountDescription { get; set; }

    [XmlElement(DataType = "string", ElementName = "authorisedBonusAccountDescription", IsNullable = true)]
    public string AuthorisedBonusAccountDescription { get; set; }

    [XmlElement(DataType = "date", ElementName = "workingDurationAssignmentStartDate", IsNullable = true)]
    public DateTime? WorkingDurationAssignmentStartDate { get; set; }

    [XmlElement(DataType = "date", ElementName = "workingDurationAssignmentEndDate", IsNullable = true)]
    public DateTime? WorkingDurationAssignmentEndDate { get; set; }

    [XmlElement(DataType = "date", ElementName = "periodicOvertimeHourAssignmentEndDate", IsNullable = true)]
    public DateTime? PeriodicOvertimeHourAssignmentEndDate { get; set; }

    [XmlElement(DataType = "date", ElementName = "authorisedAccountAssignmentEndDate", IsNullable = true)]
    public DateTime? AuthorisedAccountAssignmentEndDate { get; set; }

    [XmlElement(DataType = "date", ElementName = "checkProgrammeAssignmentEndDate", IsNullable = true)]
    public DateTime? CheckProgrammeAssignmentEndDate { get; set; }

    [XmlElement(DataType = "date", ElementName = "authorisedFunctionAssignmentStartDate", IsNullable = true)]
    public DateTime? AuthorisedFunctionAssignmentStartDate { get; set; }

    [XmlElement(DataType = "string", ElementName = "authorisedSpecialHoursAccountDescription", IsNullable = true)]
    public string AuthorisedSpecialHoursAccountDescription { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "compensatoryLeaveAuthorisedFunction", IsNullable = true)]
    public bool? CompensatoryLeaveAuthorisedFunction { get; set; }

    [XmlElement(DataType = "string", ElementName = "authorisedSpecialHoursAccountAbbreviation", IsNullable = true)]
    public string AuthorisedSpecialHoursAccountAbbreviation { get; set; }

    [XmlElement(DataType = "string", ElementName = "workCycleDescription", IsNullable = true)]
    public string WorkCycleDescription { get; set; }

    [XmlElement(DataType = "int", ElementName = "hourlyBasisType", IsNullable = true)]
    public int? HourlyBasisType { get; set; }

    [XmlElement(DataType = "date", ElementName = "workCycleStartDate", IsNullable = true)]
    public DateTime? WorkCycleStartDate { get; set; }

    [XmlElement(DataType = "string", ElementName = "currentContractRateCode", IsNullable = true)]
    public string CurrentContractRateCode { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "flexileaveAuthorisedFunction", IsNullable = true)]
    public bool? FlexileaveAuthorisedFunction { get; set; }

    [XmlElement(DataType = "date", ElementName = "authorisedFunctionAssignmentEndDate", IsNullable = true)]
    public DateTime? AuthorisedFunctionAssignmentEndDate { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "automaticAbsenceAuthorisedFunction", IsNullable = true)]
    public bool? AutomaticAbsenceAuthorisedFunction { get; set; }

    [XmlElement(DataType = "string", ElementName = "currentContractRateDescription", IsNullable = true)]
    public string CurrentContractRateDescription { get; set; }
  }
}
