
//.ExportPresenceNotificationTimeResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportPresenceNotificationTimeResponse")]
  public class ExportPresenceNotificationTimeResponse
  {
    [XmlArray(ElementName = "exportedPresenceNotificationTime", IsNullable = false, Order = 0)]
    public List<PresenceNotificationTime> ExportedPresenceNotificationTime { get; set; }
  }
}
