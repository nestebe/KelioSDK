
//.DeleteSpecialHourTypeAuthorizations




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "deleteSpecialHourTypeAuthorizations")]
  public class DeleteSpecialHourTypeAuthorizations
  {
    [XmlArray(ElementName = "specialHourTypeAuthorizationsToImport", IsNullable = false, Order = 0)]
    public List<AccountAuthorization> SpecialHourTypeAuthorizationsToImport { get; set; }
  }
}
