
//.ExportActualDailyGenericTotalsFromDateToDateResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportActualDailyGenericTotalsFromDateToDateResponse")]
  public class ExportActualDailyGenericTotalsFromDateToDateResponse
  {
    [XmlArray(ElementName = "exportedDailyGenericTotals", IsNullable = false, Order = 0)]
    public List<DailyGenericTotal> ExportedDailyGenericTotals { get; set; }
  }
}
