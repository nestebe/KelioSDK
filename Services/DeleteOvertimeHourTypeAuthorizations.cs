
//.DeleteOvertimeHourTypeAuthorizations




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "deleteOvertimeHourTypeAuthorizations")]
  public class DeleteOvertimeHourTypeAuthorizations
  {
    [XmlArray(ElementName = "overtimeHourTypeAuthorizationsToImport", IsNullable = false, Order = 0)]
    public List<AccountAuthorization> OvertimeHourTypeAuthorizationsToImport { get; set; }
  }
}
