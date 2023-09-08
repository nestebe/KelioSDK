
// Type: KelioSDK.Models.AutoExitAssignment




using System;
using System.Globalization;
using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "AutoExitAssignment")]
  public class AutoExitAssignment : DailyScheduleWindow
  {
    [XmlElement(DataType = "int", ElementName = "automaticExitTimeRelativeIndex", IsNullable = true)]
    public int? AutomaticExitTimeRelativeIndex { get; set; }

    [XmlElement(DataType = "double", ElementName = "automaticExitTimeRelativeDelta", IsNullable = true)]
    public double? AutomaticExitTimeRelativeDelta { get; set; }

    [XmlElement(DataType = "double", ElementName = "cancelByClockingOutTimeLimitRelativeDelta", IsNullable = true)]
    public double? CancelByClockingOutTimeLimitRelativeDelta { get; set; }

    [XmlElement(DataType = "int", ElementName = "cancelByClockingOutTimeLimitRelativeIndex", IsNullable = true)]
    public int? CancelByClockingOutTimeLimitRelativeIndex { get; set; }

    [XmlElement(DataType = "int", ElementName = "cancelRangeEndTimePosition", IsNullable = true)]
    public int? CancelRangeEndTimePosition { get; set; }

    [XmlElement(DataType = "double", ElementName = "cancelRangeEndTimeRelativeDelta", IsNullable = true)]
    public double? CancelRangeEndTimeRelativeDelta { get; set; }

    [XmlElement(DataType = "int", ElementName = "cancelByClockingOutTimeLimitPosition", IsNullable = true)]
    public int? CancelByClockingOutTimeLimitPosition { get; set; }

    [XmlElement(DataType = "int", ElementName = "cancelRangeEndTimeRelativeIndex", IsNullable = true)]
    public int? CancelRangeEndTimeRelativeIndex { get; set; }

    [XmlElement(DataType = "double", ElementName = "cancelRangeStartTimeRelativeDelta", IsNullable = true)]
    public double? CancelRangeStartTimeRelativeDelta { get; set; }

    [XmlElement(DataType = "int", ElementName = "cancelRangeStartTimePosition", IsNullable = true)]
    public int? CancelRangeStartTimePosition { get; set; }

    [XmlIgnore]
    public TimeSpan? CancelRangeEndTime { get; set; }

    [XmlElement(DataType = "string", ElementName = "cancelRangeEndTime", IsNullable = true)]
    public string CancelRangeEndTimeField
    {
      get
      {
        return !this.CancelRangeEndTime.HasValue ? (string) null : this.CancelRangeEndTime.Value.ToString("hh\\:mm\\:ss", (IFormatProvider) CultureInfo.InvariantCulture);
      }
      set
      {
        this.CancelRangeEndTime = value == null ? new TimeSpan?() : new TimeSpan?(TimeSpan.ParseExact(value, "hh\\:mm\\:ss", (IFormatProvider) CultureInfo.InvariantCulture));
      }
    }

    [XmlIgnore]
    public TimeSpan? CancelRangeStartTime { get; set; }

    [XmlElement(DataType = "string", ElementName = "cancelRangeStartTime", IsNullable = true)]
    public string CancelRangeStartTimeField
    {
      get
      {
        return !this.CancelRangeStartTime.HasValue ? (string) null : this.CancelRangeStartTime.Value.ToString("hh\\:mm\\:ss", (IFormatProvider) CultureInfo.InvariantCulture);
      }
      set
      {
        this.CancelRangeStartTime = value == null ? new TimeSpan?() : new TimeSpan?(TimeSpan.ParseExact(value, "hh\\:mm\\:ss", (IFormatProvider) CultureInfo.InvariantCulture));
      }
    }

    [XmlIgnore]
    public TimeSpan? CancelByClockingOutTimeLimit { get; set; }

    [XmlElement(DataType = "string", ElementName = "cancelByClockingOutTimeLimit", IsNullable = true)]
    public string CancelByClockingOutTimeLimitField
    {
      get
      {
        return !this.CancelByClockingOutTimeLimit.HasValue ? (string) null : this.CancelByClockingOutTimeLimit.Value.ToString("hh\\:mm\\:ss", (IFormatProvider) CultureInfo.InvariantCulture);
      }
      set
      {
        this.CancelByClockingOutTimeLimit = value == null ? new TimeSpan?() : new TimeSpan?(TimeSpan.ParseExact(value, "hh\\:mm\\:ss", (IFormatProvider) CultureInfo.InvariantCulture));
      }
    }

    [XmlIgnore]
    public TimeSpan? AutomaticExitTime { get; set; }

    [XmlElement(DataType = "string", ElementName = "automaticExitTime", IsNullable = true)]
    public string AutomaticExitTimeField
    {
      get
      {
        return !this.AutomaticExitTime.HasValue ? (string) null : this.AutomaticExitTime.Value.ToString("hh\\:mm\\:ss", (IFormatProvider) CultureInfo.InvariantCulture);
      }
      set
      {
        this.AutomaticExitTime = value == null ? new TimeSpan?() : new TimeSpan?(TimeSpan.ParseExact(value, "hh\\:mm\\:ss", (IFormatProvider) CultureInfo.InvariantCulture));
      }
    }

    [XmlElement(DataType = "int", ElementName = "automaticExitTimePosition", IsNullable = true)]
    public int? AutomaticExitTimePosition { get; set; }

    [XmlElement(DataType = "int", ElementName = "cancelRangeStartTimeRelativeIndex", IsNullable = true)]
    public int? CancelRangeStartTimeRelativeIndex { get; set; }
  }
}
