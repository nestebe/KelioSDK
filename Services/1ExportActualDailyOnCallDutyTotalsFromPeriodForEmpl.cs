
//.ExportActualDailyOnCallDutyTotalsFromPeriodForEmployeeListResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportActualDailyOnCallDutyTotalsFromPeriodForEmployeeListResponse")]
  public class ExportActualDailyOnCallDutyTotalsFromPeriodForEmployeeListResponse
  {
    [XmlArray(ElementName = "exportedDailyOnCallDutyTotals", IsNullable = false, Order = 0)]
    public List<DailyOnCallDutyTotal> ExportedDailyOnCallDutyTotals { get; set; }
  }
}
