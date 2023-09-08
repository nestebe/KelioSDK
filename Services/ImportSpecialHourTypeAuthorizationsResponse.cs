
//.ImportSpecialHourTypeAuthorizationsResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importSpecialHourTypeAuthorizationsResponse")]
  public class ImportSpecialHourTypeAuthorizationsResponse
  {
    [XmlArray(ElementName = "specialHourTypeAuthorizationsInError", IsNullable = false, Order = 0)]
    public List<AccountAuthorization> SpecialHourTypeAuthorizationsInError { get; set; }
  }
}
