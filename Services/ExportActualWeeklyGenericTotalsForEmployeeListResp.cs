
//.ExportActualWeeklyGenericTotalsForEmployeeListResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportActualWeeklyGenericTotalsForEmployeeListResponse")]
  public class ExportActualWeeklyGenericTotalsForEmployeeListResponse
  {
    [XmlArray(ElementName = "exportedWeeklyGenericTotals", IsNullable = false, Order = 0)]
    public List<WeeklyGenericTotal> ExportedWeeklyGenericTotals { get; set; }
  }
}
