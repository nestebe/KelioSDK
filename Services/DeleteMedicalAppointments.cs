
//.DeleteMedicalAppointments




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "deleteMedicalAppointments")]
  public class DeleteMedicalAppointments
  {
    [XmlArray(ElementName = "medicalAppointmentsToDelete", IsNullable = false, Order = 0)]
    public List<MedicalAppointment> MedicalAppointmentsToDelete { get; set; }
  }
}
