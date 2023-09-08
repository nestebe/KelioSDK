
//.ExportPlannedDailySpecialHourTotalsFromRelativeDatesForEmployeeListResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportPlannedDailySpecialHourTotalsFromRelativeDatesForEmployeeListResponse")]
  public class ExportPlannedDailySpecialHourTotalsFromRelativeDatesForEmployeeListResponse
  {
    [XmlArray(ElementName = "exportedDailySpecialHourTotals", IsNullable = false, Order = 0)]
    public List<DailySpecialHourTotal> ExportedDailySpecialHourTotals { get; set; }
  }
}
