
//.ExportActualDailyOvertimeHourTotalsFromRelativeDatesForEmployeeListResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportActualDailyOvertimeHourTotalsFromRelativeDatesForEmployeeListResponse")]
  public class ExportActualDailyOvertimeHourTotalsFromRelativeDatesForEmployeeListResponse
  {
    [XmlArray(ElementName = "exportedDailyOvertimeHourTotals", IsNullable = false, Order = 0)]
    public List<DailyOvertimeHourTotal> ExportedDailyOvertimeHourTotals { get; set; }
  }
}
