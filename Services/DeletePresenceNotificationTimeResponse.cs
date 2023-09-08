
//.DeletePresenceNotificationTimeResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "deletePresenceNotificationTimeResponse")]
  public class DeletePresenceNotificationTimeResponse
  {
    [XmlArray(ElementName = "presenceNotificationTimeInError", IsNullable = false, Order = 0)]
    public List<PresenceNotificationTime> PresenceNotificationTimeInError { get; set; }
  }
}
