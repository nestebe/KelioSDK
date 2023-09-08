
//.ExportPlannedPeriodicalOvertimeHourTotalsResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportPlannedPeriodicalOvertimeHourTotalsResponse")]
  public class ExportPlannedPeriodicalOvertimeHourTotalsResponse
  {
    [XmlArray(ElementName = "exportedPeriodicalOvertimeHourTotals", IsNullable = false, Order = 0)]
    public List<PeriodicOvertimeHourTotal> ExportedPeriodicalOvertimeHourTotals { get; set; }
  }
}
