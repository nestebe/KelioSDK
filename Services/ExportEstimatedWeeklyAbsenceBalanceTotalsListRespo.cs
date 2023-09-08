
//.ExportEstimatedWeeklyAbsenceBalanceTotalsListResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportEstimatedWeeklyAbsenceBalanceTotalsListResponse")]
  public class ExportEstimatedWeeklyAbsenceBalanceTotalsListResponse
  {
    [XmlArray(ElementName = "exportedWeeklyAbsenceBalanceTotals", IsNullable = false, Order = 0)]
    public List<WeeklyAbsenceBalanceTotal> ExportedWeeklyAbsenceBalanceTotals { get; set; }
  }
}
