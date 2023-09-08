
//.ExportActualPeriodicalBonusTotalsForEmployeeListResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportActualPeriodicalBonusTotalsForEmployeeListResponse")]
  public class ExportActualPeriodicalBonusTotalsForEmployeeListResponse
  {
    [XmlArray(ElementName = "exportedPeriodicalBonusTotals", IsNullable = false, Order = 0)]
    public List<PeriodicBonusTotal> ExportedPeriodicalBonusTotals { get; set; }
  }
}
