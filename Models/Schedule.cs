
// Type: KelioSDK.Models.Schedule




using KelioSDK.Common;
using System;
using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "Schedule")]
  public class Schedule : ObjectBase
  {
    [XmlElement(DataType = "string", ElementName = "scheduleDescription", IsNullable = true)]
    public string ScheduleDescription { get; set; }

    [XmlElement(DataType = "int", ElementName = "processingDay", IsNullable = true)]
    public int? ProcessingDay { get; set; }

    [XmlElement(DataType = "date", ElementName = "cycleStartdate", IsNullable = true)]
    public DateTime? CycleStartdate { get; set; }

    [XmlElement(DataType = "string", ElementName = "scheduleAbbreviation", IsNullable = true)]
    public string ScheduleAbbreviation { get; set; }

    [XmlElement(DataType = "int", ElementName = "colour", IsNullable = true)]
    public int? Colour { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "searchUsingAbbreviation", IsNullable = true)]
    public bool? SearchUsingAbbreviation { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "searchUsingDescription", IsNullable = true)]
    public bool? SearchUsingDescription { get; set; }

    [XmlElement(DataType = "int", ElementName = "scheduleKey", IsNullable = true)]
    public int? ScheduleKey { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "balanceManagement", IsNullable = true)]
    public bool? BalanceManagement { get; set; }

    [XmlElement(DataType = "double", ElementName = "endOfCycleMaximumBalanceLimit", IsNullable = true)]
    public double? EndOfCycleMaximumBalanceLimit { get; set; }

    [XmlElement(DataType = "double", ElementName = "flexileaveMinimumDuration", IsNullable = true)]
    public double? FlexileaveMinimumDuration { get; set; }

    [XmlElement(DataType = "double", ElementName = "cycleMaximumBalanceLimit", IsNullable = true)]
    public double? CycleMaximumBalanceLimit { get; set; }

    [XmlElement(DataType = "double", ElementName = "endOfDayMaximumBalanceLimit", IsNullable = true)]
    public double? EndOfDayMaximumBalanceLimit { get; set; }

    [XmlElement(DataType = "double", ElementName = "endOfWeekMaximumBalanceLimit", IsNullable = true)]
    public double? EndOfWeekMaximumBalanceLimit { get; set; }

    [XmlElement(DataType = "double", ElementName = "periodMaximumBalanceLimit", IsNullable = true)]
    public double? PeriodMaximumBalanceLimit { get; set; }

    [XmlElement(DataType = "double", ElementName = "weekMaximumBalanceLimit", IsNullable = true)]
    public double? WeekMaximumBalanceLimit { get; set; }

    [XmlElement(DataType = "double", ElementName = "endOfPeriodMaximumBalanceLimit", IsNullable = true)]
    public double? EndOfPeriodMaximumBalanceLimit { get; set; }

    [XmlElement(DataType = "double", ElementName = "endOfCycleMinimumBalanceLimit", IsNullable = true)]
    public double? EndOfCycleMinimumBalanceLimit { get; set; }

    [XmlElement(DataType = "double", ElementName = "periodMinimumBalanceLimit", IsNullable = true)]
    public double? PeriodMinimumBalanceLimit { get; set; }

    [XmlElement(DataType = "double", ElementName = "endOfDayMinimumBalanceLimit", IsNullable = true)]
    public double? EndOfDayMinimumBalanceLimit { get; set; }

    [XmlElement(DataType = "int", ElementName = "cycleWeeksNumber", IsNullable = true)]
    public int? CycleWeeksNumber { get; set; }

    [XmlElement(DataType = "double", ElementName = "endOfWeekMinimumBalanceLimit", IsNullable = true)]
    public double? EndOfWeekMinimumBalanceLimit { get; set; }

    [XmlElement(DataType = "double", ElementName = "weekMinimumBalanceLimit", IsNullable = true)]
    public double? WeekMinimumBalanceLimit { get; set; }

    [XmlElement(DataType = "double", ElementName = "cycleMinimumBalanceLimit", IsNullable = true)]
    public double? CycleMinimumBalanceLimit { get; set; }

    [XmlElement(DataType = "double", ElementName = "endOfPeriodMinimumBalanceLimit", IsNullable = true)]
    public double? EndOfPeriodMinimumBalanceLimit { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "endOfPeriodGainedOvertimeCalculation", IsNullable = true)]
    public bool? EndOfPeriodGainedOvertimeCalculation { get; set; }

    [XmlElement(DataType = "date", ElementName = "annualisedOvertime1ApplicationDate", IsNullable = true)]
    public DateTime? AnnualisedOvertime1ApplicationDate { get; set; }

    [XmlElement(DataType = "date", ElementName = "annualisedOvertime2ApplicationDate", IsNullable = true)]
    public DateTime? AnnualisedOvertime2ApplicationDate { get; set; }

    [XmlElement(DataType = "double", ElementName = "annualisedOvertime1Value", IsNullable = true)]
    public double? AnnualisedOvertime1Value { get; set; }

    [XmlElement(DataType = "double", ElementName = "annualisedOvertime2Value", IsNullable = true)]
    public double? AnnualisedOvertime2Value { get; set; }

    [XmlElement(DataType = "double", ElementName = "minimumBalanceToSuspendBalance", IsNullable = true)]
    public double? MinimumBalanceToSuspendBalance { get; set; }

    [XmlElement(DataType = "double", ElementName = "flexileaveMinimumBalance", IsNullable = true)]
    public double? FlexileaveMinimumBalance { get; set; }

    [XmlElement(DataType = "int", ElementName = "overtimeLimitApplication", IsNullable = true)]
    public int? OvertimeLimitApplication { get; set; }

    [XmlElement(DataType = "int", ElementName = "shiftNumber", IsNullable = true)]
    public int? ShiftNumber { get; set; }
  }
}
