
//.DeleteMedicalAppointmentsResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "deleteMedicalAppointmentsResponse")]
  public class DeleteMedicalAppointmentsResponse
  {
    [XmlArray(ElementName = "deletedMedicalAppointmentsInError", IsNullable = false, Order = 0)]
    public List<MedicalAppointment> DeletedMedicalAppointmentsInError { get; set; }
  }
}
