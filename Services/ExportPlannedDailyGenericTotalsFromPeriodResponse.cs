
//.ExportPlannedDailyGenericTotalsFromPeriodResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportPlannedDailyGenericTotalsFromPeriodResponse")]
  public class ExportPlannedDailyGenericTotalsFromPeriodResponse
  {
    [XmlArray(ElementName = "exportedDailyGenericTotals", IsNullable = false, Order = 0)]
    public List<DailyGenericTotal> ExportedDailyGenericTotals { get; set; }
  }
}
