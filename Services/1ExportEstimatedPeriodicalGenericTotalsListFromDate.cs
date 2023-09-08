
//.ExportEstimatedPeriodicalGenericTotalsListFromDateToDateForEmployeeListResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportEstimatedPeriodicalGenericTotalsListFromDateToDateForEmployeeListResponse")]
  public class ExportEstimatedPeriodicalGenericTotalsListFromDateToDateForEmployeeListResponse
  {
    [XmlArray(ElementName = "exportedPeriodicalGenericTotals", IsNullable = false, Order = 0)]
    public List<PeriodicGenericTotal> ExportedPeriodicalGenericTotals { get; set; }
  }
}
