
//.ExportPlannedWeeklyOvertimeHourTotalsListResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportPlannedWeeklyOvertimeHourTotalsListResponse")]
  public class ExportPlannedWeeklyOvertimeHourTotalsListResponse
  {
    [XmlArray(ElementName = "exportedWeeklyOvertimeHourTotals", IsNullable = false, Order = 0)]
    public List<WeeklyOvertimeHourTotal> ExportedWeeklyOvertimeHourTotals { get; set; }
  }
}
