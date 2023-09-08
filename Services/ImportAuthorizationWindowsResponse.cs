
//.ImportAuthorizationWindowsResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importAuthorizationWindowsResponse")]
  public class ImportAuthorizationWindowsResponse
  {
    [XmlArray(ElementName = "authorizationWindowsInError", IsNullable = false, Order = 0)]
    public List<AuthorizationWindow> AuthorizationWindowsInError { get; set; }
  }
}
