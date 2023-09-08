
//.DeleteEmergencyContact




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "deleteEmergencyContact")]
  public class DeleteEmergencyContact
  {
    [XmlArray(ElementName = "emergencyContactListToDelete", IsNullable = false, Order = 0)]
    public List<EmergencyContact> EmergencyContactListToDelete { get; set; }
  }
}
