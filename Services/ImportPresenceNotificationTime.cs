
//.ImportPresenceNotificationTime




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importPresenceNotificationTime")]
  public class ImportPresenceNotificationTime
  {
    [XmlArray(ElementName = "presenceNotificationTimeToImport", IsNullable = false, Order = 0)]
    public List<PresenceNotificationTime> PresenceNotificationTimeToImport { get; set; }
  }
}
