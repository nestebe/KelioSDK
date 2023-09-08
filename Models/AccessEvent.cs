
// Type: KelioSDK.Models.AccessEvent




using KelioSDK.Common;
using System;
using System.Globalization;
using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "AccessEvent")]
  public class AccessEvent : ObjectBase
  {
    [XmlElement(DataType = "string", ElementName = "inputPeripheralDescription", IsNullable = true)]
    public string InputPeripheralDescription { get; set; }

    [XmlElement(DataType = "string", ElementName = "acknowledgementEmployeeIdentificationCode", IsNullable = true)]
    public string AcknowledgementEmployeeIdentificationCode { get; set; }

    [XmlElement(DataType = "string", ElementName = "outputPeripheralDescription", IsNullable = true)]
    public string OutputPeripheralDescription { get; set; }

    [XmlElement(DataType = "string", ElementName = "dailyScheduleDescription", IsNullable = true)]
    public string DailyScheduleDescription { get; set; }

    [XmlElement(DataType = "string", ElementName = "alarmDescription", IsNullable = true)]
    public string AlarmDescription { get; set; }

    [XmlElement(DataType = "int", ElementName = "eventKey", IsNullable = true)]
    public int? EventKey { get; set; }

    [XmlElement(DataType = "string", ElementName = "accessDescription", IsNullable = true)]
    public string AccessDescription { get; set; }

    [XmlElement(DataType = "date", ElementName = "eventDate", IsNullable = true)]
    public DateTime? EventDate { get; set; }

    [XmlElement(DataType = "string", ElementName = "personSurname", IsNullable = true)]
    public string PersonSurname { get; set; }

    [XmlElement(DataType = "string", ElementName = "personBadgeCode", IsNullable = true)]
    public string PersonBadgeCode { get; set; }

    [XmlElement(DataType = "int", ElementName = "personKey", IsNullable = true)]
    public int? PersonKey { get; set; }

    [XmlElement(DataType = "int", ElementName = "eventType", IsNullable = true)]
    public int? EventType { get; set; }

    [XmlElement(DataType = "int", ElementName = "accessPermissionCause", IsNullable = true)]
    public int? AccessPermissionCause { get; set; }

    [XmlElement(DataType = "string", ElementName = "enteredCode", IsNullable = true)]
    public string EnteredCode { get; set; }

    [XmlElement(DataType = "double", ElementName = "durationInHours", IsNullable = true)]
    public double? DurationInHours { get; set; }

    [XmlElement(DataType = "string", ElementName = "readerDescription", IsNullable = true)]
    public string ReaderDescription { get; set; }

    [XmlElement(DataType = "string", ElementName = "terminalDescription", IsNullable = true)]
    public string TerminalDescription { get; set; }

    [XmlElement(DataType = "string", ElementName = "acknowledgementEmployeeIdentificationNumber", IsNullable = true)]
    public string AcknowledgementEmployeeIdentificationNumber { get; set; }

    [XmlElement(DataType = "string", ElementName = "concentratorDescription", IsNullable = true)]
    public string ConcentratorDescription { get; set; }

    [XmlElement(DataType = "string", ElementName = "originalZoneDescription", IsNullable = true)]
    public string OriginalZoneDescription { get; set; }

    [XmlElement(DataType = "string", ElementName = "personFirstName", IsNullable = true)]
    public string PersonFirstName { get; set; }

    [XmlElement(DataType = "int", ElementName = "crossingMode", IsNullable = true)]
    public int? CrossingMode { get; set; }

    [XmlElement(DataType = "string", ElementName = "accessRuleDescription", IsNullable = true)]
    public string AccessRuleDescription { get; set; }

    [XmlElement(DataType = "string", ElementName = "acknowledgementPersonSurname", IsNullable = true)]
    public string AcknowledgementPersonSurname { get; set; }

    [XmlElement(DataType = "string", ElementName = "acknowledgementPersonBadgeCode", IsNullable = true)]
    public string AcknowledgementPersonBadgeCode { get; set; }

    [XmlElement(DataType = "string", ElementName = "accessedZoneDescription", IsNullable = true)]
    public string AccessedZoneDescription { get; set; }

    [XmlIgnore]
    public TimeSpan? EventHour { get; set; }

    [XmlElement(DataType = "string", ElementName = "eventHour", IsNullable = true)]
    public string EventHourField
    {
      get
      {
        return !this.EventHour.HasValue ? (string) null : this.EventHour.Value.ToString("hh\\:mm\\:ss", (IFormatProvider) CultureInfo.InvariantCulture);
      }
      set
      {
        this.EventHour = value == null ? new TimeSpan?() : new TimeSpan?(TimeSpan.ParseExact(value, "hh\\:mm\\:ss", (IFormatProvider) CultureInfo.InvariantCulture));
      }
    }

    [XmlElement(DataType = "string", ElementName = "acknowledgementPersonFirstName", IsNullable = true)]
    public string AcknowledgementPersonFirstName { get; set; }

    [XmlElement(DataType = "string", ElementName = "employeeIdentificationCode", IsNullable = true)]
    public string EmployeeIdentificationCode { get; set; }

    [XmlElement(DataType = "string", ElementName = "employeeIdentificationNumber", IsNullable = true)]
    public string EmployeeIdentificationNumber { get; set; }

    [XmlElement(DataType = "string", ElementName = "siteDescription", IsNullable = true)]
    public string SiteDescription { get; set; }
  }
}
