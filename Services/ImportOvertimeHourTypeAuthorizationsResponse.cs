
//.ImportOvertimeHourTypeAuthorizationsResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importOvertimeHourTypeAuthorizationsResponse")]
  public class ImportOvertimeHourTypeAuthorizationsResponse
  {
    [XmlArray(ElementName = "overtimeHourTypeAuthorizationsInError", IsNullable = false, Order = 0)]
    public List<AccountAuthorization> OvertimeHourTypeAuthorizationsInError { get; set; }
  }
}
