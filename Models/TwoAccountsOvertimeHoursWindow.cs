
// Type: KelioSDK.Models.TwoAccountsOvertimeHoursWindow




using System;
using System.Globalization;
using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "TwoAccountsOvertimeHoursWindow")]
  public class TwoAccountsOvertimeHoursWindow : DailyScheduleWindow
  {
    [XmlIgnore]
    public TimeSpan? RangeStartTime { get; set; }

    [XmlElement(DataType = "string", ElementName = "rangeStartTime", IsNullable = true)]
    public string RangeStartTimeField
    {
      get
      {
        return !this.RangeStartTime.HasValue ? (string) null : this.RangeStartTime.Value.ToString("hh\\:mm\\:ss", (IFormatProvider) CultureInfo.InvariantCulture);
      }
      set
      {
        this.RangeStartTime = value == null ? new TimeSpan?() : new TimeSpan?(TimeSpan.ParseExact(value, "hh\\:mm\\:ss", (IFormatProvider) CultureInfo.InvariantCulture));
      }
    }

    [XmlIgnore]
    public TimeSpan? RangeEndTime { get; set; }

    [XmlElement(DataType = "string", ElementName = "rangeEndTime", IsNullable = true)]
    public string RangeEndTimeField
    {
      get
      {
        return !this.RangeEndTime.HasValue ? (string) null : this.RangeEndTime.Value.ToString("hh\\:mm\\:ss", (IFormatProvider) CultureInfo.InvariantCulture);
      }
      set
      {
        this.RangeEndTime = value == null ? new TimeSpan?() : new TimeSpan?(TimeSpan.ParseExact(value, "hh\\:mm\\:ss", (IFormatProvider) CultureInfo.InvariantCulture));
      }
    }

    [XmlElement(DataType = "double", ElementName = "minimumTime", IsNullable = true)]
    public double? MinimumTime { get; set; }

    [XmlElement(DataType = "int", ElementName = "rangeEndTimePosition", IsNullable = true)]
    public int? RangeEndTimePosition { get; set; }

    [XmlElement(DataType = "int", ElementName = "rangeStartTimeRelativeIndex", IsNullable = true)]
    public int? RangeStartTimeRelativeIndex { get; set; }

    [XmlElement(DataType = "double", ElementName = "rangeEndTimeRelativeDelta", IsNullable = true)]
    public double? RangeEndTimeRelativeDelta { get; set; }

    [XmlElement(DataType = "int", ElementName = "rangeEndTimeRelativeIndex", IsNullable = true)]
    public int? RangeEndTimeRelativeIndex { get; set; }

    [XmlElement(DataType = "int", ElementName = "rangeStartTimePosition", IsNullable = true)]
    public int? RangeStartTimePosition { get; set; }

    [XmlElement(DataType = "double", ElementName = "rangeStartTimeRelativeDelta", IsNullable = true)]
    public double? RangeStartTimeRelativeDelta { get; set; }

    [XmlElement(DataType = "string", ElementName = "typeDescription", IsNullable = true)]
    public string TypeDescription { get; set; }

    [XmlElement(DataType = "int", ElementName = "typeKey", IsNullable = true)]
    public int? TypeKey { get; set; }

    [XmlElement(DataType = "string", ElementName = "typeAbbreviation", IsNullable = true)]
    public string TypeAbbreviation { get; set; }

    [XmlElement(DataType = "int", ElementName = "secondTypeKey", IsNullable = true)]
    public int? SecondTypeKey { get; set; }

    [XmlElement(DataType = "string", ElementName = "secondTypeDescription", IsNullable = true)]
    public string SecondTypeDescription { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "minimumTimeIsRelative", IsNullable = true)]
    public bool? MinimumTimeIsRelative { get; set; }

    [XmlElement(DataType = "string", ElementName = "secondTypeAbbreviation", IsNullable = true)]
    public string SecondTypeAbbreviation { get; set; }
  }
}
