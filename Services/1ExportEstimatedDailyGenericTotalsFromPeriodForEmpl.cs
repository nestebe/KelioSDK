
//.ExportEstimatedDailyGenericTotalsFromPeriodForEmployeeListResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportEstimatedDailyGenericTotalsFromPeriodForEmployeeListResponse")]
  public class ExportEstimatedDailyGenericTotalsFromPeriodForEmployeeListResponse
  {
    [XmlArray(ElementName = "exportedDailyGenericTotals", IsNullable = false, Order = 0)]
    public List<DailyGenericTotal> ExportedDailyGenericTotals { get; set; }
  }
}
