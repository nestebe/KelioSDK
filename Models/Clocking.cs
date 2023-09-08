
// Type: KelioSDK.Models.Clocking




using System;
using System.Globalization;
using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "Clocking")]
  public class Clocking : EmployeeInformation
  {
    [XmlElement(DataType = "date", ElementName = "date", IsNullable = true)]
    public DateTime? Date { get; set; }

    [XmlIgnore]
    public TimeSpan? Time { get; set; }

    [XmlElement(DataType = "string", ElementName = "time", IsNullable = true)]
    public string TimeField
    {
      get
      {
        return !this.Time.HasValue ? (string) null : this.Time.Value.ToString("hh\\:mm\\:ss", (IFormatProvider) CultureInfo.InvariantCulture);
      }
      set
      {
        this.Time = value == null ? new TimeSpan?() : new TimeSpan?(TimeSpan.ParseExact(value, "hh\\:mm\\:ss", (IFormatProvider) CultureInfo.InvariantCulture));
      }
    }

    [XmlElement(DataType = "int", ElementName = "overtimeTypeKey", IsNullable = true)]
    public int? OvertimeTypeKey { get; set; }

    [XmlElement(DataType = "int", ElementName = "terminalKey", IsNullable = true)]
    public int? TerminalKey { get; set; }

    [XmlElement(DataType = "string", ElementName = "overtimeTypeAbbreviation", IsNullable = true)]
    public string OvertimeTypeAbbreviation { get; set; }

    [XmlElement(DataType = "string", ElementName = "overtimeTypeDescription", IsNullable = true)]
    public string OvertimeTypeDescription { get; set; }

    [XmlElement(DataType = "short", ElementName = "obtainingMode", IsNullable = true)]
    public short? ObtainingMode { get; set; }

    [XmlElement(DataType = "float", ElementName = "longitude", IsNullable = true)]
    public float? Longitude { get; set; }

    [XmlElement(DataType = "float", ElementName = "latitude", IsNullable = true)]
    public float? Latitude { get; set; }

    [XmlElement(DataType = "short", ElementName = "clockingTypeIndicator", IsNullable = true)]
    public short? ClockingTypeIndicator { get; set; }

    [XmlElement(DataType = "short", ElementName = "inOutIndicator", IsNullable = true)]
    public short? InOutIndicator { get; set; }

    [XmlElement(DataType = "int", ElementName = "geolocationPrecision", IsNullable = true)]
    public int? GeolocationPrecision { get; set; }

    [XmlElement(DataType = "string", ElementName = "absenceTypeDescription", IsNullable = true)]
    public string AbsenceTypeDescription { get; set; }

    [XmlElement(DataType = "string", ElementName = "readerDescription", IsNullable = true)]
    public string ReaderDescription { get; set; }

    [XmlElement(DataType = "int", ElementName = "absenceTypeKey", IsNullable = true)]
    public int? AbsenceTypeKey { get; set; }

    [XmlElement(DataType = "string", ElementName = "absenceTypeAbbreviation", IsNullable = true)]
    public string AbsenceTypeAbbreviation { get; set; }

    [XmlElement(DataType = "string", ElementName = "terminalDescription", IsNullable = true)]
    public string TerminalDescription { get; set; }

    [XmlElement(DataType = "short", ElementName = "geolocationStatus", IsNullable = true)]
    public short? GeolocationStatus { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "automatic", IsNullable = true)]
    public bool? Automatic { get; set; }

    [XmlElement(DataType = "int", ElementName = "timePosition", IsNullable = true)]
    public int? TimePosition { get; set; }

    [XmlElement(DataType = "int", ElementName = "clockingKey", IsNullable = true)]
    public int? ClockingKey { get; set; }

    [XmlElement(DataType = "int", ElementName = "readerKey", IsNullable = true)]
    public int? ReaderKey { get; set; }
  }
}
