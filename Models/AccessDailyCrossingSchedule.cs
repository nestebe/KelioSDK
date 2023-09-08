
// Type: KelioSDK.Models.AccessDailyCrossingSchedule




using KelioSDK.Common;
using System;
using System.Globalization;
using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "AccessDailyCrossingSchedule")]
  public class AccessDailyCrossingSchedule : ObjectBase
  {
    [XmlIgnore]
    public TimeSpan? StartTime { get; set; }

    [XmlElement(DataType = "string", ElementName = "startTime", IsNullable = true)]
    public string StartTimeField
    {
      get
      {
        return !this.StartTime.HasValue ? (string) null : this.StartTime.Value.ToString("hh\\:mm\\:ss", (IFormatProvider) CultureInfo.InvariantCulture);
      }
      set
      {
        this.StartTime = value == null ? new TimeSpan?() : new TimeSpan?(TimeSpan.ParseExact(value, "hh\\:mm\\:ss", (IFormatProvider) CultureInfo.InvariantCulture));
      }
    }

    [XmlIgnore]
    public TimeSpan? EndTime { get; set; }

    [XmlElement(DataType = "string", ElementName = "endTime", IsNullable = true)]
    public string EndTimeField
    {
      get
      {
        return !this.EndTime.HasValue ? (string) null : this.EndTime.Value.ToString("hh\\:mm\\:ss", (IFormatProvider) CultureInfo.InvariantCulture);
      }
      set
      {
        this.EndTime = value == null ? new TimeSpan?() : new TimeSpan?(TimeSpan.ParseExact(value, "hh\\:mm\\:ss", (IFormatProvider) CultureInfo.InvariantCulture));
      }
    }

    [XmlElement(DataType = "boolean", ElementName = "isStandardSchedule", IsNullable = true)]
    public bool? IsStandardSchedule { get; set; }

    [XmlElement(DataType = "string", ElementName = "scheduleDescription", IsNullable = true)]
    public string ScheduleDescription { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "endTimeAdjustment", IsNullable = true)]
    public bool? EndTimeAdjustment { get; set; }

    [XmlElement(DataType = "int", ElementName = "crossingMode", IsNullable = true)]
    public int? CrossingMode { get; set; }

    [XmlElement(DataType = "int", ElementName = "scheduleKey", IsNullable = true)]
    public int? ScheduleKey { get; set; }

    [XmlElement(DataType = "int", ElementName = "colourCode", IsNullable = true)]
    public int? ColourCode { get; set; }
  }
}
