
//.ExportEstimatedDailyAbsenceBalanceTotalsFromDateToDateForEmployeeListResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportEstimatedDailyAbsenceBalanceTotalsFromDateToDateForEmployeeListResponse")]
  public class ExportEstimatedDailyAbsenceBalanceTotalsFromDateToDateForEmployeeListResponse
  {
    [XmlArray(ElementName = "exportedDailyAbsenceBalanceTotals", IsNullable = false, Order = 0)]
    public List<DailyAbsenceBalanceTotal> ExportedDailyAbsenceBalanceTotals { get; set; }
  }
}
