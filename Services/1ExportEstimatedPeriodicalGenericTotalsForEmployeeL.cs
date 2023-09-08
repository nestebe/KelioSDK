
//.ExportEstimatedPeriodicalGenericTotalsForEmployeeListResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportEstimatedPeriodicalGenericTotalsForEmployeeListResponse")]
  public class ExportEstimatedPeriodicalGenericTotalsForEmployeeListResponse
  {
    [XmlArray(ElementName = "exportedPeriodicalGenericTotals", IsNullable = false, Order = 0)]
    public List<PeriodicGenericTotal> ExportedPeriodicalGenericTotals { get; set; }
  }
}
