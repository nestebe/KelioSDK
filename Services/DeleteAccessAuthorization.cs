
//.DeleteAccessAuthorization




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "deleteAccessAuthorization")]
  public class DeleteAccessAuthorization
  {
    [XmlArray(ElementName = "accessAuthorizationToDelete", IsNullable = false, Order = 0)]
    public List<AccessAuthorization> AccessAuthorizationToDelete { get; set; }
  }
}
