
//.DeletePresenceNotificationTime




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "deletePresenceNotificationTime")]
  public class DeletePresenceNotificationTime
  {
    [XmlArray(ElementName = "presenceNotificationTimeToDelete", IsNullable = false, Order = 0)]
    public List<PresenceNotificationTime> PresenceNotificationTimeToDelete { get; set; }
  }
}
