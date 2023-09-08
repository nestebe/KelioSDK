
//.ExportPlannedWeeklyOnCallDutyTotalsListFromDateToDateResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportPlannedWeeklyOnCallDutyTotalsListFromDateToDateResponse")]
  public class ExportPlannedWeeklyOnCallDutyTotalsListFromDateToDateResponse
  {
    [XmlArray(ElementName = "exportedWeeklyOnCallDutyTotals", IsNullable = false, Order = 0)]
    public List<WeeklyOnCallDutyTotal> ExportedWeeklyOnCallDutyTotals { get; set; }
  }
}
