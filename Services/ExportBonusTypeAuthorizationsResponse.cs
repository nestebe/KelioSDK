
//.ExportBonusTypeAuthorizationsResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportBonusTypeAuthorizationsResponse")]
  public class ExportBonusTypeAuthorizationsResponse
  {
    [XmlArray(ElementName = "exportedBonusTypeAuthorizations", IsNullable = false, Order = 0)]
    public List<AccountAuthorization> ExportedBonusTypeAuthorizations { get; set; }
  }
}
