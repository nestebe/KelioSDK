
// Type: KelioSDK.Models.DailyScheduleWindow




using KelioSDK.Common;
using System;
using System.Globalization;
using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "DailyScheduleWindow")]
  public class DailyScheduleWindow : ObjectBase
  {
    [XmlElement(DataType = "int", ElementName = "windowType", IsNullable = true)]
    public int? WindowType { get; set; }

    [XmlIgnore]
    public TimeSpan? WindowStartTime { get; set; }

    [XmlElement(DataType = "string", ElementName = "windowStartTime", IsNullable = true)]
    public string WindowStartTimeField
    {
      get
      {
        return !this.WindowStartTime.HasValue ? (string) null : this.WindowStartTime.Value.ToString("hh\\:mm\\:ss", (IFormatProvider) CultureInfo.InvariantCulture);
      }
      set
      {
        this.WindowStartTime = value == null ? new TimeSpan?() : new TimeSpan?(TimeSpan.ParseExact(value, "hh\\:mm\\:ss", (IFormatProvider) CultureInfo.InvariantCulture));
      }
    }

    [XmlIgnore]
    public TimeSpan? WindowEndTime { get; set; }

    [XmlElement(DataType = "string", ElementName = "windowEndTime", IsNullable = true)]
    public string WindowEndTimeField
    {
      get
      {
        return !this.WindowEndTime.HasValue ? (string) null : this.WindowEndTime.Value.ToString("hh\\:mm\\:ss", (IFormatProvider) CultureInfo.InvariantCulture);
      }
      set
      {
        this.WindowEndTime = value == null ? new TimeSpan?() : new TimeSpan?(TimeSpan.ParseExact(value, "hh\\:mm\\:ss", (IFormatProvider) CultureInfo.InvariantCulture));
      }
    }

    [XmlElement(DataType = "string", ElementName = "dailyScheduleAbbreviation", IsNullable = true)]
    public string DailyScheduleAbbreviation { get; set; }

    [XmlElement(DataType = "string", ElementName = "dailyScheduleDescription", IsNullable = true)]
    public string DailyScheduleDescription { get; set; }

    [XmlElement(DataType = "int", ElementName = "windowIndex", IsNullable = true)]
    public int? WindowIndex { get; set; }

    [XmlElement(DataType = "int", ElementName = "windowStartTimeRelativeIndex", IsNullable = true)]
    public int? WindowStartTimeRelativeIndex { get; set; }

    [XmlElement(DataType = "double", ElementName = "windowStartTimeRelativeDelta", IsNullable = true)]
    public double? WindowStartTimeRelativeDelta { get; set; }

    [XmlElement(DataType = "double", ElementName = "windowEndTimeRelativeDelta", IsNullable = true)]
    public double? WindowEndTimeRelativeDelta { get; set; }

    [XmlElement(DataType = "int", ElementName = "windowEndTimePosition", IsNullable = true)]
    public int? WindowEndTimePosition { get; set; }

    [XmlElement(DataType = "int", ElementName = "windowEndTimeRelativeIndex", IsNullable = true)]
    public int? WindowEndTimeRelativeIndex { get; set; }

    [XmlElement(DataType = "int", ElementName = "windowStartTimePosition", IsNullable = true)]
    public int? WindowStartTimePosition { get; set; }

    [XmlElement(DataType = "int", ElementName = "dailyScheduleKey", IsNullable = true)]
    public int? DailyScheduleKey { get; set; }

    [XmlElement(DataType = "int", ElementName = "dailyScheduleWindowKey", IsNullable = true)]
    public int? DailyScheduleWindowKey { get; set; }
  }
}
