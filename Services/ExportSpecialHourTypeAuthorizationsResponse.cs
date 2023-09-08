
//.ExportSpecialHourTypeAuthorizationsResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportSpecialHourTypeAuthorizationsResponse")]
  public class ExportSpecialHourTypeAuthorizationsResponse
  {
    [XmlArray(ElementName = "exportedSpecialHourTypeAuthorizations", IsNullable = false, Order = 0)]
    public List<AccountAuthorization> ExportedSpecialHourTypeAuthorizations { get; set; }
  }
}
