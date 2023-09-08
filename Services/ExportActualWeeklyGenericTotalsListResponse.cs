
//.ExportActualWeeklyGenericTotalsListResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportActualWeeklyGenericTotalsListResponse")]
  public class ExportActualWeeklyGenericTotalsListResponse
  {
    [XmlArray(ElementName = "exportedWeeklyGenericTotals", IsNullable = false, Order = 0)]
    public List<WeeklyGenericTotal> ExportedWeeklyGenericTotals { get; set; }
  }
}
