
//.ImportAccessWeeklyAuthorizationSchedulesResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importAccessWeeklyAuthorizationSchedulesResponse")]
  public class ImportAccessWeeklyAuthorizationSchedulesResponse
  {
    [XmlArray(ElementName = "accessWeeklyAuthorizationSchedulesInError", IsNullable = false, Order = 0)]
    public List<AccessWeeklyAuthorization> AccessWeeklyAuthorizationSchedulesInError { get; set; }
  }
}
