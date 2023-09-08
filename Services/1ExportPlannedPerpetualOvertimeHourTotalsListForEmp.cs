
//.ExportPlannedPerpetualOvertimeHourTotalsListForEmployeeListResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportPlannedPerpetualOvertimeHourTotalsListForEmployeeListResponse")]
  public class ExportPlannedPerpetualOvertimeHourTotalsListForEmployeeListResponse
  {
    [XmlArray(ElementName = "exportedPerpetualOvertimeHourTotals", IsNullable = false, Order = 0)]
    public List<PerpetualOvertimeHourTotal> ExportedPerpetualOvertimeHourTotals { get; set; }
  }
}
