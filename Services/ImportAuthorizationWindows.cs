
//.ImportAuthorizationWindows




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importAuthorizationWindows")]
  public class ImportAuthorizationWindows
  {
    [XmlArray(ElementName = "authorizationWindowsToImport", IsNullable = false, Order = 0)]
    public List<AuthorizationWindow> AuthorizationWindowsToImport { get; set; }
  }
}
