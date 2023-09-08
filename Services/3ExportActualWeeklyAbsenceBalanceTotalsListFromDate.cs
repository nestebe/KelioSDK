
//.ExportActualWeeklyAbsenceBalanceTotalsListFromDateToDateResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportActualWeeklyAbsenceBalanceTotalsListFromDateToDateResponse")]
  public class ExportActualWeeklyAbsenceBalanceTotalsListFromDateToDateResponse
  {
    [XmlArray(ElementName = "exportedWeeklyAbsenceBalanceTotals", IsNullable = false, Order = 0)]
    public List<WeeklyAbsenceBalanceTotal> ExportedWeeklyAbsenceBalanceTotals { get; set; }
  }
}
