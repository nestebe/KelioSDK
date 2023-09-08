
//.ImportAccessAuthorizationResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importAccessAuthorizationResponse")]
  public class ImportAccessAuthorizationResponse
  {
    [XmlArray(ElementName = "accessAuthorizationInError", IsNullable = false, Order = 0)]
    public List<AccessAuthorization> AccessAuthorizationInError { get; set; }
  }
}
