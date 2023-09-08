
//.ExportBonusTypeAuthorizationsListResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportBonusTypeAuthorizationsListResponse")]
  public class ExportBonusTypeAuthorizationsListResponse
  {
    [XmlArray(ElementName = "exportedBonusTypeAuthorizations", IsNullable = false, Order = 0)]
    public List<AccountAuthorization> ExportedBonusTypeAuthorizations { get; set; }
  }
}
