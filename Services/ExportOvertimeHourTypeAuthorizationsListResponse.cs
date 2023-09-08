
//.ExportOvertimeHourTypeAuthorizationsListResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportOvertimeHourTypeAuthorizationsListResponse")]
  public class ExportOvertimeHourTypeAuthorizationsListResponse
  {
    [XmlArray(ElementName = "exportedOvertimeHourTypeAuthorizations", IsNullable = false, Order = 0)]
    public List<AccountAuthorization> ExportedOvertimeHourTypeAuthorizations { get; set; }
  }
}
