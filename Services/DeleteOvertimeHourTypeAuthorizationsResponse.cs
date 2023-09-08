
//.DeleteOvertimeHourTypeAuthorizationsResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "deleteOvertimeHourTypeAuthorizationsResponse")]
  public class DeleteOvertimeHourTypeAuthorizationsResponse
  {
    [XmlArray(ElementName = "deletedOvertimeHourTypeAuthorizationsInError", IsNullable = false, Order = 0)]
    public List<AccountAuthorization> DeletedOvertimeHourTypeAuthorizationsInError { get; set; }
  }
}
