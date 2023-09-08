
//.ImportAccessWeeklyCrossingSchedulesResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importAccessWeeklyCrossingSchedulesResponse")]
  public class ImportAccessWeeklyCrossingSchedulesResponse
  {
    [XmlArray(ElementName = "accessWeeklyCrossingSchedulesInError", IsNullable = false, Order = 0)]
    public List<AccessWeeklySchedule> AccessWeeklyCrossingSchedulesInError { get; set; }
  }
}
