
//.ImportEmergencyContact




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importEmergencyContact")]
  public class ImportEmergencyContact
  {
    [XmlArray(ElementName = "emergencyContactToImport", IsNullable = false, Order = 0)]
    public List<EmergencyContact> EmergencyContactToImport { get; set; }
  }
}
