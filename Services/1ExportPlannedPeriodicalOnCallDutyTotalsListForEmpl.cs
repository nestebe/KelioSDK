
//.ExportPlannedPeriodicalOnCallDutyTotalsListForEmployeeListResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportPlannedPeriodicalOnCallDutyTotalsListForEmployeeListResponse")]
  public class ExportPlannedPeriodicalOnCallDutyTotalsListForEmployeeListResponse
  {
    [XmlArray(ElementName = "exportedPeriodicalOnCallDutyTotals", IsNullable = false, Order = 0)]
    public List<PeriodicOnCallDutyTotal> ExportedPeriodicalOnCallDutyTotals { get; set; }
  }
}
