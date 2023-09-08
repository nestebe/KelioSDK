
//.ExportDailyBalanceTotalsListResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportDailyBalanceTotalsListResponse")]
  public class ExportDailyBalanceTotalsListResponse
  {
    [XmlArray(ElementName = "exportedDailyBalanceTotals", IsNullable = false, Order = 0)]
    public List<DailyBalanceTotal> ExportedDailyBalanceTotals { get; set; }
  }
}
