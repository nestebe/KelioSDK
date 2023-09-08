
//.ImportBonusTypeAuthorizationsResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importBonusTypeAuthorizationsResponse")]
  public class ImportBonusTypeAuthorizationsResponse
  {
    [XmlArray(ElementName = "bonusTypeAuthorizationsInError", IsNullable = false, Order = 0)]
    public List<AccountAuthorization> BonusTypeAuthorizationsInError { get; set; }
  }
}
