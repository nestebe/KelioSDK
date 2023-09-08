
//.ExportOvertimeHourTypeAuthorizationsResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportOvertimeHourTypeAuthorizationsResponse")]
  public class ExportOvertimeHourTypeAuthorizationsResponse
  {
    [XmlArray(ElementName = "exportedOvertimeHourTypeAuthorizations", IsNullable = false, Order = 0)]
    public List<AccountAuthorization> ExportedOvertimeHourTypeAuthorizations { get; set; }
  }
}
