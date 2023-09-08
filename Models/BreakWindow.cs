
// Type: KelioSDK.Models.BreakWindow




using System;
using System.Globalization;
using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "BreakWindow")]
  public class BreakWindow : DailyScheduleWindow
  {
    [XmlElement(DataType = "boolean", ElementName = "minimumWorkedTimeRelative", IsNullable = true)]
    public bool? MinimumWorkedTimeRelative { get; set; }

    [XmlElement(DataType = "double", ElementName = "anomalyMinimumBreakDuration", IsNullable = true)]
    public double? AnomalyMinimumBreakDuration { get; set; }

    [XmlElement(DataType = "double", ElementName = "anomalyMaximumBreakDuration", IsNullable = true)]
    public double? AnomalyMaximumBreakDuration { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "tooShortBreakAnomaly", IsNullable = true)]
    public bool? TooShortBreakAnomaly { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "tooLongBreakAnomaly", IsNullable = true)]
    public bool? TooLongBreakAnomaly { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "anomalyMinimumBreakDurationRelative", IsNullable = true)]
    public bool? AnomalyMinimumBreakDurationRelative { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "deducedTimeIfAbsenceClockedIsRelative", IsNullable = true)]
    public bool? DeducedTimeIfAbsenceClockedIsRelative { get; set; }

    [XmlElement(DataType = "double", ElementName = "minimumBreakDuration", IsNullable = true)]
    public double? MinimumBreakDuration { get; set; }

    [XmlIgnore]
    public TimeSpan? MinimumWorkedTimeStart { get; set; }

    [XmlElement(DataType = "string", ElementName = "minimumWorkedTimeStart", IsNullable = true)]
    public string MinimumWorkedTimeStartField
    {
      get
      {
        return !this.MinimumWorkedTimeStart.HasValue ? (string) null : this.MinimumWorkedTimeStart.Value.ToString("hh\\:mm\\:ss", (IFormatProvider) CultureInfo.InvariantCulture);
      }
      set
      {
        this.MinimumWorkedTimeStart = value == null ? new TimeSpan?() : new TimeSpan?(TimeSpan.ParseExact(value, "hh\\:mm\\:ss", (IFormatProvider) CultureInfo.InvariantCulture));
      }
    }

    [XmlIgnore]
    public TimeSpan? MinimumWorkedTimeEnd { get; set; }

    [XmlElement(DataType = "string", ElementName = "minimumWorkedTimeEnd", IsNullable = true)]
    public string MinimumWorkedTimeEndField
    {
      get
      {
        return !this.MinimumWorkedTimeEnd.HasValue ? (string) null : this.MinimumWorkedTimeEnd.Value.ToString("hh\\:mm\\:ss", (IFormatProvider) CultureInfo.InvariantCulture);
      }
      set
      {
        this.MinimumWorkedTimeEnd = value == null ? new TimeSpan?() : new TimeSpan?(TimeSpan.ParseExact(value, "hh\\:mm\\:ss", (IFormatProvider) CultureInfo.InvariantCulture));
      }
    }

    [XmlElement(DataType = "double", ElementName = "minimumWorkedTime", IsNullable = true)]
    public double? MinimumWorkedTime { get; set; }

    [XmlElement(DataType = "double", ElementName = "deducedTimeIfAbsenceClocked", IsNullable = true)]
    public double? DeducedTimeIfAbsenceClocked { get; set; }

    [XmlElement(DataType = "double", ElementName = "deducedTimeIfNoBreakTaken", IsNullable = true)]
    public double? DeducedTimeIfNoBreakTaken { get; set; }

    [XmlElement(DataType = "short", ElementName = "breakDeducting", IsNullable = true)]
    public short? BreakDeducting { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "isWithoutBreak", IsNullable = true)]
    public bool? IsWithoutBreak { get; set; }

    [XmlElement(DataType = "int", ElementName = "minimumWorkedTimeEndPosition", IsNullable = true)]
    public int? MinimumWorkedTimeEndPosition { get; set; }

    [XmlElement(DataType = "int", ElementName = "minimumWorkedTimeStartRelativeIndex", IsNullable = true)]
    public int? MinimumWorkedTimeStartRelativeIndex { get; set; }

    [XmlElement(DataType = "double", ElementName = "minimumWorkedTimeEndRelativeDelta", IsNullable = true)]
    public double? MinimumWorkedTimeEndRelativeDelta { get; set; }

    [XmlElement(DataType = "int", ElementName = "minimumWorkedTimeEndRelativeIndex", IsNullable = true)]
    public int? MinimumWorkedTimeEndRelativeIndex { get; set; }

    [XmlElement(DataType = "int", ElementName = "minimumWorkedTimeStartPosition", IsNullable = true)]
    public int? MinimumWorkedTimeStartPosition { get; set; }

    [XmlElement(DataType = "double", ElementName = "minimumWorkedTimeStartRelativeDelta", IsNullable = true)]
    public double? MinimumWorkedTimeStartRelativeDelta { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "visualizedInThePrintouts", IsNullable = true)]
    public bool? VisualizedInThePrintouts { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "oneTimeBreak", IsNullable = true)]
    public bool? OneTimeBreak { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "anomalyMaximumBreakDurationRelative", IsNullable = true)]
    public bool? AnomalyMaximumBreakDurationRelative { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "minimumBreakDurationIsRelative", IsNullable = true)]
    public bool? MinimumBreakDurationIsRelative { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "estimatedResultsAnomaly", IsNullable = true)]
    public bool? EstimatedResultsAnomaly { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "deducedTimeIfNoBreakTakenIsRelative", IsNullable = true)]
    public bool? DeducedTimeIfNoBreakTakenIsRelative { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "breakTakenBetweenFirstClockingInAndLastClockingOut", IsNullable = true)]
    public bool? BreakTakenBetweenFirstClockingInAndLastClockingOut { get; set; }
  }
}
