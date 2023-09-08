
//.ExportPresenceNotificationTimeDeclarationResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportPresenceNotificationTimeDeclarationResponse")]
  public class ExportPresenceNotificationTimeDeclarationResponse
  {
    [XmlArray(ElementName = "exportedPresenceNotificationTimeDeclaration", IsNullable = false, Order = 0)]
    public List<PresenceNotificationTimeDeclaration> ExportedPresenceNotificationTimeDeclaration { get; set; }
  }
}
