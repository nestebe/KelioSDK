
//.ExportActualWeeklySpecialHourTotalsListFromDateToDateResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportActualWeeklySpecialHourTotalsListFromDateToDateResponse")]
  public class ExportActualWeeklySpecialHourTotalsListFromDateToDateResponse
  {
    [XmlArray(ElementName = "exportedWeeklySpecialHourTotals", IsNullable = false, Order = 0)]
    public List<WeeklySpecialHourTotal> ExportedWeeklySpecialHourTotals { get; set; }
  }
}
