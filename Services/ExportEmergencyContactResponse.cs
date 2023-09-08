
//.ExportEmergencyContactResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportEmergencyContactResponse")]
  public class ExportEmergencyContactResponse
  {
    [XmlArray(ElementName = "exportedEmergencyContact", IsNullable = false, Order = 0)]
    public List<EmergencyContact> ExportedEmergencyContact { get; set; }
  }
}
