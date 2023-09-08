
//.DeleteBonusTypeAuthorizationsResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "deleteBonusTypeAuthorizationsResponse")]
  public class DeleteBonusTypeAuthorizationsResponse
  {
    [XmlArray(ElementName = "deletedBonusTypeAuthorizationsInError", IsNullable = false, Order = 0)]
    public List<AccountAuthorization> DeletedBonusTypeAuthorizationsInError { get; set; }
  }
}
