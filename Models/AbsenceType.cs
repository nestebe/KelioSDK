
// Type: KelioSDK.Models.AbsenceType




using System;
using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "AbsenceType")]
  public class AbsenceType : Type
  {
    [XmlElement(DataType = "boolean", ElementName = "visualizedInThePrintouts", IsNullable = true)]
    public bool? VisualizedInThePrintouts { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "commentRequired", IsNullable = true)]
    public bool? CommentRequired { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "outOfControlledTotal", IsNullable = true)]
    public bool? OutOfControlledTotal { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "absenceTimeTakenIntoAccountForActivity", IsNullable = true)]
    public bool? AbsenceTimeTakenIntoAccountForActivity { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "calculationOfOvertimeHours", IsNullable = true)]
    public bool? CalculationOfOvertimeHours { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "calculationOfSpecialHoursAndBonuses", IsNullable = true)]
    public bool? CalculationOfSpecialHoursAndBonuses { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "includingRoudingTimeWindows", IsNullable = true)]
    public bool? IncludingRoudingTimeWindows { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "includedInTheAnnualisedHoursActualTotal", IsNullable = true)]
    public bool? IncludedInTheAnnualisedHoursActualTotal { get; set; }

    [XmlElement(DataType = "string", ElementName = "defaultComment", IsNullable = true)]
    public string DefaultComment { get; set; }

    [XmlElement(DataType = "int", ElementName = "colour", IsNullable = true)]
    public int? Colour { get; set; }

    [XmlElement(DataType = "short", ElementName = "totalMode", IsNullable = true)]
    public short? TotalMode { get; set; }

    [XmlElement(DataType = "short", ElementName = "grid", IsNullable = true)]
    public short? Grid { get; set; }

    [XmlElement(DataType = "double", ElementName = "durationOfAbsence", IsNullable = true)]
    public double? DurationOfAbsence { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "paid", IsNullable = true)]
    public bool? Paid { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "isMission", IsNullable = true)]
    public bool? IsMission { get; set; }

    [XmlElement(DataType = "short", ElementName = "durationType", IsNullable = true)]
    public short? DurationType { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "calculationOfExoneratedOvertimeHours", IsNullable = true)]
    public bool? CalculationOfExoneratedOvertimeHours { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "actual", IsNullable = true)]
    public bool? Actual { get; set; }

    [XmlElement(DataType = "string", ElementName = "absenceBalanceAbbreviation", IsNullable = true)]
    public string AbsenceBalanceAbbreviation { get; set; }

    [XmlElement(DataType = "string", ElementName = "absenceBalanceDescription", IsNullable = true)]
    public string AbsenceBalanceDescription { get; set; }

    [XmlElement(DataType = "int", ElementName = "absenceBalanceKey", IsNullable = true)]
    public int? AbsenceBalanceKey { get; set; }

    [XmlElement(DataType = "int", ElementName = "typePriorityLevel", IsNullable = true)]
    public int? TypePriorityLevel { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "displayBalancesDetail", IsNullable = true)]
    public bool? DisplayBalancesDetail { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "displayBalancesTotal", IsNullable = true)]
    public bool? DisplayBalancesTotal { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "additionMinimumTimeToRecover", IsNullable = true)]
    public bool? AdditionMinimumTimeToRecover { get; set; }

    [XmlElement(DataType = "short", ElementName = "calculationModeInAnnualisedHoursPeriod", IsNullable = true)]
    public short? CalculationModeInAnnualisedHoursPeriod { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "swipedOnTerminal", IsNullable = true)]
    public bool? SwipedOnTerminal { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "estimated", IsNullable = true)]
    public bool? Estimated { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "calculationWithinTheWindows", IsNullable = true)]
    public bool? CalculationWithinTheWindows { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "modifiesTheBalance", IsNullable = true)]
    public bool? ModifiesTheBalance { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "businessTripLimitedToTheDay", IsNullable = true)]
    public bool? BusinessTripLimitedToTheDay { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "oneDayAbsence", IsNullable = true)]
    public bool? OneDayAbsence { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "noticeCessationWorkTypeAssociated", IsNullable = true)]
    public bool? NoticeCessationWorkTypeAssociated { get; set; }

    [XmlElement(DataType = "date", ElementName = "resetDate", IsNullable = true)]
    public DateTime? ResetDate { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "displayTypeDescriptionInMailCalendar", IsNullable = true)]
    public bool? DisplayTypeDescriptionInMailCalendar { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "synchroniseAbsenceInMailCalendar", IsNullable = true)]
    public bool? SynchroniseAbsenceInMailCalendar { get; set; }

    [XmlElement(DataType = "string", ElementName = "balanceAbbreviationDisplayedInAbsenceRequests", IsNullable = true)]
    public string BalanceAbbreviationDisplayedInAbsenceRequests { get; set; }

    [XmlElement(DataType = "string", ElementName = "balanceDescriptionDisplayedInAbsenceRequests", IsNullable = true)]
    public string BalanceDescriptionDisplayedInAbsenceRequests { get; set; }

    [XmlElement(DataType = "string", ElementName = "entryMode", IsNullable = true)]
    public string EntryMode { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "halfDayAbsenceOnPublicHoliday", IsNullable = true)]
    public bool? HalfDayAbsenceOnPublicHoliday { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "halfDayAbsence", IsNullable = true)]
    public bool? HalfDayAbsence { get; set; }

    [XmlElement(DataType = "double", ElementName = "limitedDurationForClockedAbsences", IsNullable = true)]
    public double? LimitedDurationForClockedAbsences { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "limitDurationOfClockedAbsences", IsNullable = true)]
    public bool? LimitDurationOfClockedAbsences { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "convertedIntoAnAbsenceFile", IsNullable = true)]
    public bool? ConvertedIntoAnAbsenceFile { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "enterAbsencesOnTerminal", IsNullable = true)]
    public bool? EnterAbsencesOnTerminal { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "calculationOfTimeOffInLieu", IsNullable = true)]
    public bool? CalculationOfTimeOffInLieu { get; set; }
  }
}
