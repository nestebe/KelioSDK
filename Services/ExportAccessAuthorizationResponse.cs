
//.ExportAccessAuthorizationResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportAccessAuthorizationResponse")]
  public class ExportAccessAuthorizationResponse
  {
    [XmlArray(ElementName = "exportedAccessAuthorization", IsNullable = false, Order = 0)]
    public List<AccessAuthorization> ExportedAccessAuthorization { get; set; }
  }
}
