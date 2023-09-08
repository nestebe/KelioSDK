
//.ExportPresenceNotificationTimeDeclaration




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportPresenceNotificationTimeDeclaration")]
  public class ExportPresenceNotificationTimeDeclaration
  {
    [XmlArray(ElementName = "exportFilter", IsNullable = false, Order = 0)]
    public List<AskedClockingDeclaration> ExportFilter { get; set; }
  }
}
