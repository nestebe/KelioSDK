
//.ExportActualPeriodicalBalanceTotalsListResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportActualPeriodicalBalanceTotalsListResponse")]
  public class ExportActualPeriodicalBalanceTotalsListResponse
  {
    [XmlArray(ElementName = "exportedPeriodicalBalanceTotals", IsNullable = false, Order = 0)]
    public List<PeriodicBalanceTotal> ExportedPeriodicalBalanceTotals { get; set; }
  }
}
