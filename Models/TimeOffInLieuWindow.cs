
// Type: KelioSDK.Models.TimeOffInLieuWindow




using System;
using System.Globalization;
using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "TimeOffInLieuWindow")]
  public class TimeOffInLieuWindow : DailyScheduleWindow
  {
    [XmlElement(DataType = "double", ElementName = "TOILWindowEndTimeRelativeDelta", IsNullable = true)]
    public double? TOILWindowEndTimeRelativeDelta { get; set; }

    [XmlElement(DataType = "int", ElementName = "TOILWindowStartTimePosition", IsNullable = true)]
    public int? TOILWindowStartTimePosition { get; set; }

    [XmlElement(DataType = "int", ElementName = "TOILWindowEndTimePosition", IsNullable = true)]
    public int? TOILWindowEndTimePosition { get; set; }

    [XmlElement(DataType = "double", ElementName = "minCreditedTime", IsNullable = true)]
    public double? MinCreditedTime { get; set; }

    [XmlElement(DataType = "double", ElementName = "maxCreditedTime", IsNullable = true)]
    public double? MaxCreditedTime { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "minimumTimeIsRelative", IsNullable = true)]
    public bool? MinimumTimeIsRelative { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "TOILTimeIsContinuous", IsNullable = true)]
    public bool? TOILTimeIsContinuous { get; set; }

    [XmlIgnore]
    public TimeSpan? TOILWindowEndTime { get; set; }

    [XmlElement(DataType = "string", ElementName = "TOILWindowEndTime", IsNullable = true)]
    public string TOILWindowEndTimeField
    {
      get
      {
        return !this.TOILWindowEndTime.HasValue ? (string) null : this.TOILWindowEndTime.Value.ToString("hh\\:mm\\:ss", (IFormatProvider) CultureInfo.InvariantCulture);
      }
      set
      {
        this.TOILWindowEndTime = value == null ? new TimeSpan?() : new TimeSpan?(TimeSpan.ParseExact(value, "hh\\:mm\\:ss", (IFormatProvider) CultureInfo.InvariantCulture));
      }
    }

    [XmlElement(DataType = "double", ElementName = "minimumTime", IsNullable = true)]
    public double? MinimumTime { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "TOILTimeIsDeducedFromActualTotal", IsNullable = true)]
    public bool? TOILTimeIsDeducedFromActualTotal { get; set; }

    [XmlIgnore]
    public TimeSpan? TOILWindowStartTime { get; set; }

    [XmlElement(DataType = "string", ElementName = "TOILWindowStartTime", IsNullable = true)]
    public string TOILWindowStartTimeField
    {
      get
      {
        return !this.TOILWindowStartTime.HasValue ? (string) null : this.TOILWindowStartTime.Value.ToString("hh\\:mm\\:ss", (IFormatProvider) CultureInfo.InvariantCulture);
      }
      set
      {
        this.TOILWindowStartTime = value == null ? new TimeSpan?() : new TimeSpan?(TimeSpan.ParseExact(value, "hh\\:mm\\:ss", (IFormatProvider) CultureInfo.InvariantCulture));
      }
    }

    [XmlElement(DataType = "int", ElementName = "TOILWindowStartTimeRelativeIndex", IsNullable = true)]
    public int? TOILWindowStartTimeRelativeIndex { get; set; }

    [XmlElement(DataType = "int", ElementName = "TOILWindowEndTimeRelativeIndex", IsNullable = true)]
    public int? TOILWindowEndTimeRelativeIndex { get; set; }

    [XmlElement(DataType = "double", ElementName = "TOILWindowStartTimeRelativeDelta", IsNullable = true)]
    public double? TOILWindowStartTimeRelativeDelta { get; set; }
  }
}
