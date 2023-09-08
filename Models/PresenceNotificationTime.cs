
// Type: KelioSDK.Models.PresenceNotificationTime




using System;
using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "PresenceNotificationTime")]
  public class PresenceNotificationTime : EmployeeInformation
  {
    [XmlElement(DataType = "date", ElementName = "date", IsNullable = true)]
    public DateTime? Date { get; set; }

    [XmlElement(DataType = "int", ElementName = "morningNotificationGeolocationPrecision", IsNullable = true)]
    public int? MorningNotificationGeolocationPrecision { get; set; }

    [XmlElement(DataType = "short", ElementName = "afternoonNotificationGeolocationStatus", IsNullable = true)]
    public short? AfternoonNotificationGeolocationStatus { get; set; }

    [XmlElement(DataType = "short", ElementName = "morningNotificationGeolocationStatus", IsNullable = true)]
    public short? MorningNotificationGeolocationStatus { get; set; }

    [XmlElement(DataType = "short", ElementName = "morningNotificationObtainingMode", IsNullable = true)]
    public short? MorningNotificationObtainingMode { get; set; }

    [XmlElement(DataType = "short", ElementName = "presenceNotificationObtainingMode", IsNullable = true)]
    public short? PresenceNotificationObtainingMode { get; set; }

    [XmlElement(DataType = "int", ElementName = "morningNotificationReaderKey", IsNullable = true)]
    public int? MorningNotificationReaderKey { get; set; }

    [XmlElement(DataType = "int", ElementName = "morningNotificationTerminalKey", IsNullable = true)]
    public int? MorningNotificationTerminalKey { get; set; }

    [XmlElement(DataType = "int", ElementName = "terminalKey", IsNullable = true)]
    public int? TerminalKey { get; set; }

    [XmlElement(DataType = "double", ElementName = "presenceTime", IsNullable = true)]
    public double? PresenceTime { get; set; }

    [XmlElement(DataType = "float", ElementName = "longitude", IsNullable = true)]
    public float? Longitude { get; set; }

    [XmlElement(DataType = "float", ElementName = "latitude", IsNullable = true)]
    public float? Latitude { get; set; }

    [XmlElement(DataType = "short", ElementName = "presenceTimeObtainingMode", IsNullable = true)]
    public short? PresenceTimeObtainingMode { get; set; }

    [XmlElement(DataType = "short", ElementName = "restTimeRespectedObtainingMode", IsNullable = true)]
    public short? RestTimeRespectedObtainingMode { get; set; }

    [XmlElement(DataType = "int", ElementName = "geolocationPrecision", IsNullable = true)]
    public int? GeolocationPrecision { get; set; }

    [XmlElement(DataType = "string", ElementName = "readerDescription", IsNullable = true)]
    public string ReaderDescription { get; set; }

    [XmlElement(DataType = "string", ElementName = "terminalDescription", IsNullable = true)]
    public string TerminalDescription { get; set; }

    [XmlElement(DataType = "short", ElementName = "geolocationStatus", IsNullable = true)]
    public short? GeolocationStatus { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "RestTimeRespected", IsNullable = true)]
    public bool? RestTimeRespected { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "automatic", IsNullable = true)]
    public bool? Automatic { get; set; }

    [XmlElement(DataType = "int", ElementName = "readerKey", IsNullable = true)]
    public int? ReaderKey { get; set; }

    [XmlElement(DataType = "float", ElementName = "morningNotificationLongitude", IsNullable = true)]
    public float? MorningNotificationLongitude { get; set; }

    [XmlElement(DataType = "float", ElementName = "afternoonNotificationLatitude", IsNullable = true)]
    public float? AfternoonNotificationLatitude { get; set; }

    [XmlElement(DataType = "float", ElementName = "afternoonNotificationLongitude", IsNullable = true)]
    public float? AfternoonNotificationLongitude { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "morningPresenceNotification", IsNullable = true)]
    public bool? MorningPresenceNotification { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "afternoonPresenceNotification", IsNullable = true)]
    public bool? AfternoonPresenceNotification { get; set; }

    [XmlElement(DataType = "float", ElementName = "morningNotificationLatitude", IsNullable = true)]
    public float? MorningNotificationLatitude { get; set; }

    [XmlElement(DataType = "int", ElementName = "presenceKey", IsNullable = true)]
    public int? PresenceKey { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "presenceNotification", IsNullable = true)]
    public bool? PresenceNotification { get; set; }

    [XmlElement(DataType = "string", ElementName = "morningNotificationReaderDescription", IsNullable = true)]
    public string MorningNotificationReaderDescription { get; set; }

    [XmlElement(DataType = "int", ElementName = "afternoonNotificationGeolocationPrecision", IsNullable = true)]
    public int? AfternoonNotificationGeolocationPrecision { get; set; }

    [XmlElement(DataType = "string", ElementName = "morningNotificationTerminalDescription", IsNullable = true)]
    public string MorningNotificationTerminalDescription { get; set; }

    [XmlElement(DataType = "short", ElementName = "afternoonNotificationObtainingMode", IsNullable = true)]
    public short? AfternoonNotificationObtainingMode { get; set; }

    [XmlElement(DataType = "int", ElementName = "afternoonNotificationReaderKey", IsNullable = true)]
    public int? AfternoonNotificationReaderKey { get; set; }

    [XmlElement(DataType = "string", ElementName = "afternoonNotificationTerminalDescription", IsNullable = true)]
    public string AfternoonNotificationTerminalDescription { get; set; }

    [XmlElement(DataType = "string", ElementName = "afternoonNotificationReaderDescription", IsNullable = true)]
    public string AfternoonNotificationReaderDescription { get; set; }

    [XmlElement(DataType = "int", ElementName = "afternoonNotificationTerminalKey", IsNullable = true)]
    public int? AfternoonNotificationTerminalKey { get; set; }
  }
}
