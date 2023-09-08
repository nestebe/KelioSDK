
//.ExportEstimatedPeriodicalBalanceTotalsListForEmployeeListResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportEstimatedPeriodicalBalanceTotalsListForEmployeeListResponse")]
  public class ExportEstimatedPeriodicalBalanceTotalsListForEmployeeListResponse
  {
    [XmlArray(ElementName = "exportedPeriodicalBalanceTotals", IsNullable = false, Order = 0)]
    public List<PeriodicBalanceTotal> ExportedPeriodicalBalanceTotals { get; set; }
  }
}
