
//.ExportPlannedDailyAbsenceTotalsFromDateToDateForEmployeeListResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportPlannedDailyAbsenceTotalsFromDateToDateForEmployeeListResponse")]
  public class ExportPlannedDailyAbsenceTotalsFromDateToDateForEmployeeListResponse
  {
    [XmlArray(ElementName = "exportedDailyAbsenceTotals", IsNullable = false, Order = 0)]
    public List<DailyAbsenceTotal> ExportedDailyAbsenceTotals { get; set; }
  }
}
