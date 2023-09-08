
// Type: KelioSDK.Models.PaidBreakWithConditionalDurationWindow




using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "PaidBreakWithConditionalDurationWindow")]
  public class PaidBreakWithConditionalDurationWindow : DailyScheduleWindow
  {
    [XmlElement(DataType = "boolean", ElementName = "tooShortBreakAnomaly", IsNullable = true)]
    public bool? TooShortBreakAnomaly { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "tooLongBreakAnomaly", IsNullable = true)]
    public bool? TooLongBreakAnomaly { get; set; }

    [XmlElement(DataType = "double", ElementName = "anomalyMinimumBreakDuration", IsNullable = true)]
    public double? AnomalyMinimumBreakDuration { get; set; }

    [XmlElement(DataType = "double", ElementName = "anomalyMaximumBreakDuration", IsNullable = true)]
    public double? AnomalyMaximumBreakDuration { get; set; }

    [XmlElement(DataType = "double", ElementName = "firstBreakDuration", IsNullable = true)]
    public double? FirstBreakDuration { get; set; }

    [XmlElement(DataType = "double", ElementName = "secondBreakDuration", IsNullable = true)]
    public double? SecondBreakDuration { get; set; }

    [XmlElement(DataType = "short", ElementName = "breakNumberMinToSecondBreak", IsNullable = true)]
    public short? BreakNumberMinToSecondBreak { get; set; }

    [XmlElement(DataType = "double", ElementName = "rounding", IsNullable = true)]
    public double? Rounding { get; set; }

    [XmlElement(DataType = "double", ElementName = "timeUnit", IsNullable = true)]
    public double? TimeUnit { get; set; }

    [XmlElement(DataType = "double", ElementName = "minimumTime", IsNullable = true)]
    public double? MinimumTime { get; set; }

    [XmlElement(DataType = "double", ElementName = "tolerance", IsNullable = true)]
    public double? Tolerance { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "creditAnnualisedCompletedTotal", IsNullable = true)]
    public bool? CreditAnnualisedCompletedTotal { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "minimumTimeIsRelative", IsNullable = true)]
    public bool? MinimumTimeIsRelative { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "visualizedInThePrintouts", IsNullable = true)]
    public bool? VisualizedInThePrintouts { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "oneTimeBreak", IsNullable = true)]
    public bool? OneTimeBreak { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "anomalyMaximumBreakDurationRelative", IsNullable = true)]
    public bool? AnomalyMaximumBreakDurationRelative { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "creditsTaxExemptOvertimeHours", IsNullable = true)]
    public bool? CreditsTaxExemptOvertimeHours { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "anomalyMinimumBreakDurationRelative", IsNullable = true)]
    public bool? AnomalyMinimumBreakDurationRelative { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "estimatedResultsAnomaly", IsNullable = true)]
    public bool? EstimatedResultsAnomaly { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "deduceMaximumBreakDurationFromActualTotal", IsNullable = true)]
    public bool? DeduceMaximumBreakDurationFromActualTotal { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "breakTakenBetweenFirstClockingInAndLastClockingOut", IsNullable = true)]
    public bool? BreakTakenBetweenFirstClockingInAndLastClockingOut { get; set; }
  }
}
