
// Type: KelioSDK.Models.LateArrivalEarlyDepartureWindow




using System;
using System.Globalization;
using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "LateArrivalEarlyDepartureWindow")]
  public class LateArrivalEarlyDepartureWindow : DailyScheduleWindow
  {
    [XmlElement(DataType = "double", ElementName = "seriousnessTimeLimitRelativeDelta", IsNullable = true)]
    public double? SeriousnessTimeLimitRelativeDelta { get; set; }

    [XmlElement(DataType = "int", ElementName = "seriousnessTimeLimitRelativeIndex", IsNullable = true)]
    public int? SeriousnessTimeLimitRelativeIndex { get; set; }

    [XmlIgnore]
    public TimeSpan? SeriousnessTimeLimit { get; set; }

    [XmlElement(DataType = "string", ElementName = "seriousnessTimeLimit", IsNullable = true)]
    public string SeriousnessTimeLimitField
    {
      get
      {
        return !this.SeriousnessTimeLimit.HasValue ? (string) null : this.SeriousnessTimeLimit.Value.ToString("hh\\:mm\\:ss", (IFormatProvider) CultureInfo.InvariantCulture);
      }
      set
      {
        this.SeriousnessTimeLimit = value == null ? new TimeSpan?() : new TimeSpan?(TimeSpan.ParseExact(value, "hh\\:mm\\:ss", (IFormatProvider) CultureInfo.InvariantCulture));
      }
    }

    [XmlElement(DataType = "double", ElementName = "maxTimeBeforeAlertRelativeDelta", IsNullable = true)]
    public double? MaxTimeBeforeAlertRelativeDelta { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "lateArrival", IsNullable = true)]
    public bool? LateArrival { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "alertIfEmployeeHasTooMuch", IsNullable = true)]
    public bool? AlertIfEmployeeHasTooMuch { get; set; }

    [XmlElement(DataType = "int", ElementName = "seriousnessTimeLimitPosition", IsNullable = true)]
    public int? SeriousnessTimeLimitPosition { get; set; }
  }
}
