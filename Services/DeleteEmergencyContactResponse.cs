
//.DeleteEmergencyContactResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "deleteEmergencyContactResponse")]
  public class DeleteEmergencyContactResponse
  {
    [XmlArray(ElementName = "emergencyContactInError", IsNullable = false, Order = 0)]
    public List<EmergencyContact> EmergencyContactInError { get; set; }
  }
}
