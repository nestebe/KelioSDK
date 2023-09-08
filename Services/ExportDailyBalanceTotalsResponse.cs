
//.ExportDailyBalanceTotalsResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportDailyBalanceTotalsResponse")]
  public class ExportDailyBalanceTotalsResponse
  {
    [XmlArray(ElementName = "exportedFromDateToDateBalanceTotals", IsNullable = false, Order = 0)]
    public List<FromDateToDateBalanceTotal> ExportedFromDateToDateBalanceTotals { get; set; }
  }
}
