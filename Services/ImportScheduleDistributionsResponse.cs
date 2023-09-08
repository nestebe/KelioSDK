
//.ImportScheduleDistributionsResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importScheduleDistributionsResponse")]
  public class ImportScheduleDistributionsResponse
  {
    [XmlArray(ElementName = "scheduleDistributionsInError", IsNullable = false, Order = 0)]
    public List<ScheduleDistribution> ScheduleDistributionsInError { get; set; }
  }
}
