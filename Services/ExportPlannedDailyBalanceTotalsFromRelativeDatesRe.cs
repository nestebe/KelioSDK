
//.ExportPlannedDailyBalanceTotalsFromRelativeDatesResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportPlannedDailyBalanceTotalsFromRelativeDatesResponse")]
  public class ExportPlannedDailyBalanceTotalsFromRelativeDatesResponse
  {
    [XmlArray(ElementName = "exportedDailyBalanceTotals", IsNullable = false, Order = 0)]
    public List<DailyBalanceTotal> ExportedDailyBalanceTotals { get; set; }
  }
}
