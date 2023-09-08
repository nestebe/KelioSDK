
//.ExportEstimatedWeeklyLatenessEarlyDepartureTotalsListFromDateToDateResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportEstimatedWeeklyLatenessEarlyDepartureTotalsListFromDateToDateResponse")]
  public class ExportEstimatedWeeklyLatenessEarlyDepartureTotalsListFromDateToDateResponse
  {
    [XmlArray(ElementName = "exportedWeeklyLatenessEarlyDepartureTotals", IsNullable = false, Order = 0)]
    public List<WeeklyLatenessEarlyDepartureTotal> ExportedWeeklyLatenessEarlyDepartureTotals { get; set; }
  }
}
