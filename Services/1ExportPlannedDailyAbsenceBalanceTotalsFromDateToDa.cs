
//.ExportPlannedDailyAbsenceBalanceTotalsFromDateToDateForEmployeeListResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportPlannedDailyAbsenceBalanceTotalsFromDateToDateForEmployeeListResponse")]
  public class ExportPlannedDailyAbsenceBalanceTotalsFromDateToDateForEmployeeListResponse
  {
    [XmlArray(ElementName = "exportedDailyAbsenceBalanceTotals", IsNullable = false, Order = 0)]
    public List<DailyAbsenceBalanceTotal> ExportedDailyAbsenceBalanceTotals { get; set; }
  }
}
