
//.ExportWeeklyBalanceTotalsResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportWeeklyBalanceTotalsResponse")]
  public class ExportWeeklyBalanceTotalsResponse
  {
    [XmlArray(ElementName = "exportedWeeklyBalanceTotals", IsNullable = false, Order = 0)]
    public List<WeeklyBalanceTotal> ExportedWeeklyBalanceTotals { get; set; }
  }
}
