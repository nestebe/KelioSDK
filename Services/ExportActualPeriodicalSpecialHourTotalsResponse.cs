
//.ExportActualPeriodicalSpecialHourTotalsResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportActualPeriodicalSpecialHourTotalsResponse")]
  public class ExportActualPeriodicalSpecialHourTotalsResponse
  {
    [XmlArray(ElementName = "exportedPeriodicalSpecialHourTotals", IsNullable = false, Order = 0)]
    public List<PeriodicSpecialHourTotal> ExportedPeriodicalSpecialHourTotals { get; set; }
  }
}
