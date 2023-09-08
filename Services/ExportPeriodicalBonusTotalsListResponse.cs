
//.ExportPeriodicalBonusTotalsListResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportPeriodicalBonusTotalsListResponse")]
  public class ExportPeriodicalBonusTotalsListResponse
  {
    [XmlArray(ElementName = "exportedPeriodicalBonusTotals", IsNullable = false, Order = 0)]
    public List<PeriodicBonusTotal> ExportedPeriodicalBonusTotals { get; set; }
  }
}
