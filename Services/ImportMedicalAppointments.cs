
//.ImportMedicalAppointments




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importMedicalAppointments")]
  public class ImportMedicalAppointments
  {
    [XmlArray(ElementName = "medicalAppointmentsToImport", IsNullable = false, Order = 0)]
    public List<MedicalAppointment> MedicalAppointmentsToImport { get; set; }
  }
}
