
//.ExportPlannedDailySpecialHourTotalsFromPeriodForEmployeeListResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportPlannedDailySpecialHourTotalsFromPeriodForEmployeeListResponse")]
  public class ExportPlannedDailySpecialHourTotalsFromPeriodForEmployeeListResponse
  {
    [XmlArray(ElementName = "exportedDailySpecialHourTotals", IsNullable = false, Order = 0)]
    public List<DailySpecialHourTotal> ExportedDailySpecialHourTotals { get; set; }
  }
}
