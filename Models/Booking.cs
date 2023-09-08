
// Type: KelioSDK.Models.Booking




using KelioSDK.Common;
using System;
using System.Globalization;
using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "Booking")]
  public class Booking : ObjectBase
  {
    [XmlElement(DataType = "string", ElementName = "bookingDescription", IsNullable = true)]
    public string BookingDescription { get; set; }

    [XmlElement(DataType = "string", ElementName = "organiserBadgeCode1", IsNullable = true)]
    public string OrganiserBadgeCode1 { get; set; }

    [XmlElement(DataType = "string", ElementName = "organiserBadgeCode2", IsNullable = true)]
    public string OrganiserBadgeCode2 { get; set; }

    [XmlElement(DataType = "string", ElementName = "bookingSubject", IsNullable = true)]
    public string BookingSubject { get; set; }

    [XmlElement(DataType = "string", ElementName = "roomDescription", IsNullable = true)]
    public string RoomDescription { get; set; }

    [XmlElement(DataType = "string", ElementName = "compulsoryParticipants", IsNullable = true)]
    public string CompulsoryParticipants { get; set; }

    [XmlElement(DataType = "string", ElementName = "optionalParticipants", IsNullable = true)]
    public string OptionalParticipants { get; set; }

    [XmlElement(DataType = "string", ElementName = "roomComment", IsNullable = true)]
    public string RoomComment { get; set; }

    [XmlElement(DataType = "int", ElementName = "organiserKey", IsNullable = true)]
    public int? OrganiserKey { get; set; }

    [XmlElement(DataType = "date", ElementName = "bookingEndDate", IsNullable = true)]
    public DateTime? BookingEndDate { get; set; }

    [XmlElement(DataType = "string", ElementName = "organiserFirstname", IsNullable = true)]
    public string OrganiserFirstname { get; set; }

    [XmlElement(DataType = "int", ElementName = "bookingKey", IsNullable = true)]
    public int? BookingKey { get; set; }

    [XmlElement(DataType = "string", ElementName = "organiserSurname", IsNullable = true)]
    public string OrganiserSurname { get; set; }

    [XmlIgnore]
    public TimeSpan? BookingEndTime { get; set; }

    [XmlElement(DataType = "string", ElementName = "bookingEndTime", IsNullable = true)]
    public string BookingEndTimeField
    {
      get
      {
        return !this.BookingEndTime.HasValue ? (string) null : this.BookingEndTime.Value.ToString("hh\\:mm\\:ss", (IFormatProvider) CultureInfo.InvariantCulture);
      }
      set
      {
        this.BookingEndTime = value == null ? new TimeSpan?() : new TimeSpan?(TimeSpan.ParseExact(value, "hh\\:mm\\:ss", (IFormatProvider) CultureInfo.InvariantCulture));
      }
    }

    [XmlElement(DataType = "string", ElementName = "organiserProfessionalEmailAdress", IsNullable = true)]
    public string OrganiserProfessionalEmailAdress { get; set; }

    [XmlElement(DataType = "date", ElementName = "bookingStartDate", IsNullable = true)]
    public DateTime? BookingStartDate { get; set; }

    [XmlIgnore]
    public TimeSpan? BookingStartTime { get; set; }

    [XmlElement(DataType = "string", ElementName = "bookingStartTime", IsNullable = true)]
    public string BookingStartTimeField
    {
      get
      {
        return !this.BookingStartTime.HasValue ? (string) null : this.BookingStartTime.Value.ToString("hh\\:mm\\:ss", (IFormatProvider) CultureInfo.InvariantCulture);
      }
      set
      {
        this.BookingStartTime = value == null ? new TimeSpan?() : new TimeSpan?(TimeSpan.ParseExact(value, "hh\\:mm\\:ss", (IFormatProvider) CultureInfo.InvariantCulture));
      }
    }

    [XmlElement(DataType = "string", ElementName = "siteDescription", IsNullable = true)]
    public string SiteDescription { get; set; }

    [XmlElement(DataType = "int", ElementName = "roomKey", IsNullable = true)]
    public int? RoomKey { get; set; }
  }
}
