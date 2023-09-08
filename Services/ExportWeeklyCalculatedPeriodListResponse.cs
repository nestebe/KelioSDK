
//.ExportWeeklyCalculatedPeriodListResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportWeeklyCalculatedPeriodListResponse")]
  public class ExportWeeklyCalculatedPeriodListResponse
  {
    [XmlArray(ElementName = "exportedWeeklyCalculatedPeriod", IsNullable = false, Order = 0)]
    public List<CalculatedPeriod> ExportedWeeklyCalculatedPeriod { get; set; }
  }
}
