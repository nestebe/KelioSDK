
//.ExportWeeklyOvertimeHourTotalsResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportWeeklyOvertimeHourTotalsResponse")]
  public class ExportWeeklyOvertimeHourTotalsResponse
  {
    [XmlArray(ElementName = "exportedWeeklyOvertimeHourTotals", IsNullable = false, Order = 0)]
    public List<WeeklyOvertimeHourTotal> ExportedWeeklyOvertimeHourTotals { get; set; }
  }
}
