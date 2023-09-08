
//.ExportMedicalAppointmentsResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportMedicalAppointmentsResponse")]
  public class ExportMedicalAppointmentsResponse
  {
    [XmlArray(ElementName = "exportedMedicalAppointments", IsNullable = false, Order = 0)]
    public List<MedicalAppointment> ExportedMedicalAppointments { get; set; }
  }
}
