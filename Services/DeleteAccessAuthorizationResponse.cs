
//.DeleteAccessAuthorizationResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "deleteAccessAuthorizationResponse")]
  public class DeleteAccessAuthorizationResponse
  {
    [XmlArray(ElementName = "accessAuthorizationInError", IsNullable = false, Order = 0)]
    public List<AccessAuthorization> AccessAuthorizationInError { get; set; }
  }
}
