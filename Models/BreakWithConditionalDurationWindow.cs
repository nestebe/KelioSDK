
// Type: KelioSDK.Models.BreakWithConditionalDurationWindow




using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "BreakWithConditionalDurationWindow")]
  public class BreakWithConditionalDurationWindow : DailyScheduleWindow
  {
    [XmlElement(DataType = "double", ElementName = "anomalyMinimumBreakDuration", IsNullable = true)]
    public double? AnomalyMinimumBreakDuration { get; set; }

    [XmlElement(DataType = "double", ElementName = "anomalyMaximumBreakDuration", IsNullable = true)]
    public double? AnomalyMaximumBreakDuration { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "tooShortBreakAnomaly", IsNullable = true)]
    public bool? TooShortBreakAnomaly { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "tooLongBreakAnomaly", IsNullable = true)]
    public bool? TooLongBreakAnomaly { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "anomalyMaximumBreakDurationIsRelative", IsNullable = true)]
    public bool? AnomalyMaximumBreakDurationIsRelative { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "anomalyMinimumBreakDurationIsRelative", IsNullable = true)]
    public bool? AnomalyMinimumBreakDurationIsRelative { get; set; }

    [XmlElement(DataType = "double", ElementName = "minimumTime", IsNullable = true)]
    public double? MinimumTime { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "minimumTimeIsRelative", IsNullable = true)]
    public bool? MinimumTimeIsRelative { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "visualizedInThePrintouts", IsNullable = true)]
    public bool? VisualizedInThePrintouts { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "oneTimeBreak", IsNullable = true)]
    public bool? OneTimeBreak { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "estimatedResultsAnomaly", IsNullable = true)]
    public bool? EstimatedResultsAnomaly { get; set; }

    [XmlElement(DataType = "double", ElementName = "breakLimitDuration", IsNullable = true)]
    public double? BreakLimitDuration { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "breakTakenBetweenFirstClockingInAndLastClockingOut", IsNullable = true)]
    public bool? BreakTakenBetweenFirstClockingInAndLastClockingOut { get; set; }
  }
}
