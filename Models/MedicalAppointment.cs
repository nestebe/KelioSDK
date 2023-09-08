
// Type: KelioSDK.Models.MedicalAppointment




using System;
using System.Globalization;
using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "MedicalAppointment")]
  public class MedicalAppointment : EmployeeInformation
  {
    [XmlElement(DataType = "string", ElementName = "comment", IsNullable = true)]
    public string Comment { get; set; }

    [XmlElement(DataType = "date", ElementName = "medicalAppointmentDate", IsNullable = true)]
    public DateTime? MedicalAppointmentDate { get; set; }

    [XmlIgnore]
    public TimeSpan? MedicalAppointmentTime { get; set; }

    [XmlElement(DataType = "string", ElementName = "medicalAppointmentTime", IsNullable = true)]
    public string MedicalAppointmentTimeField
    {
      get
      {
        return !this.MedicalAppointmentTime.HasValue ? (string) null : this.MedicalAppointmentTime.Value.ToString("hh\\:mm\\:ss", (IFormatProvider) CultureInfo.InvariantCulture);
      }
      set
      {
        this.MedicalAppointmentTime = value == null ? new TimeSpan?() : new TimeSpan?(TimeSpan.ParseExact(value, "hh\\:mm\\:ss", (IFormatProvider) CultureInfo.InvariantCulture));
      }
    }

    [XmlElement(DataType = "int", ElementName = "medicalAppointmentKey", IsNullable = true)]
    public int? MedicalAppointmentKey { get; set; }

    [XmlElement(DataType = "short", ElementName = "medicalAppointmentState", IsNullable = true)]
    public short? MedicalAppointmentState { get; set; }
  }
}
