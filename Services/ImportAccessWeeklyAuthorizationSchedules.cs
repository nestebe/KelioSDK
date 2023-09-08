
//.ImportAccessWeeklyAuthorizationSchedules




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importAccessWeeklyAuthorizationSchedules")]
  public class ImportAccessWeeklyAuthorizationSchedules
  {
    [XmlArray(ElementName = "accessWeeklyAuthorizationSchedulesToImport", IsNullable = false, Order = 0)]
    public List<AccessWeeklyAuthorization> AccessWeeklyAuthorizationSchedulesToImport { get; set; }
  }
}
