
//.ExportEstimatedPeriodicalGenericTotalsListResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportEstimatedPeriodicalGenericTotalsListResponse")]
  public class ExportEstimatedPeriodicalGenericTotalsListResponse
  {
    [XmlArray(ElementName = "exportedPeriodicalGenericTotals", IsNullable = false, Order = 0)]
    public List<PeriodicGenericTotal> ExportedPeriodicalGenericTotals { get; set; }
  }
}
