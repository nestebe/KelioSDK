
//.ExportActualWeeklyAccountTotalsListFromDateToDateResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportActualWeeklyAccountTotalsListFromDateToDateResponse")]
  public class ExportActualWeeklyAccountTotalsListFromDateToDateResponse
  {
    [XmlArray(ElementName = "exportedWeeklyAccountTotals", IsNullable = false, Order = 0)]
    public List<WeeklyTotal> ExportedWeeklyAccountTotals { get; set; }
  }
}
