
//.ExportEstimatedWeeklyGenericTotalsForEmployeeListResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportEstimatedWeeklyGenericTotalsForEmployeeListResponse")]
  public class ExportEstimatedWeeklyGenericTotalsForEmployeeListResponse
  {
    [XmlArray(ElementName = "exportedWeeklyGenericTotals", IsNullable = false, Order = 0)]
    public List<WeeklyGenericTotal> ExportedWeeklyGenericTotals { get; set; }
  }
}
