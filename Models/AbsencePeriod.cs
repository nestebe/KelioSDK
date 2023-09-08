
// Type: KelioSDK.Models.AbsencePeriod




using System;
using System.Globalization;
using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "AbsencePeriod")]
  public class AbsencePeriod : EmployeeInformation
  {
    [XmlElement(DataType = "int", ElementName = "offset", IsNullable = true)]
    public int? Offset { get; set; }

    [XmlElement(DataType = "date", ElementName = "date", IsNullable = true)]
    public DateTime? Date { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "limitedToAPeriod", IsNullable = true)]
    public bool? LimitedToAPeriod { get; set; }

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

    [XmlElement(DataType = "string", ElementName = "absenceTypeDescription", IsNullable = true)]
    public string AbsenceTypeDescription { get; set; }

    [XmlElement(DataType = "int", ElementName = "absenceTypeKey", IsNullable = true)]
    public int? AbsenceTypeKey { get; set; }

    [XmlElement(DataType = "string", ElementName = "absenceTypeAbbreviation", IsNullable = true)]
    public string AbsenceTypeAbbreviation { get; set; }

    [XmlElement(DataType = "int", ElementName = "endTimePosition", IsNullable = true)]
    public int? EndTimePosition { get; set; }

    [XmlElement(DataType = "int", ElementName = "startTimePosition", IsNullable = true)]
    public int? StartTimePosition { get; set; }
  }
}
