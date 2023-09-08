
//.ImportAccessDailyCrossingSchedulesResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importAccessDailyCrossingSchedulesResponse")]
  public class ImportAccessDailyCrossingSchedulesResponse
  {
    [XmlArray(ElementName = "accessDailyCrossingSchedulesInError", IsNullable = false, Order = 0)]
    public List<AccessDailyCrossingSchedule> AccessDailyCrossingSchedulesInError { get; set; }
  }
}
