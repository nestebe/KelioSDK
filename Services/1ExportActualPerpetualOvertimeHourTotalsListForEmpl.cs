
//.ExportActualPerpetualOvertimeHourTotalsListForEmployeeListResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportActualPerpetualOvertimeHourTotalsListForEmployeeListResponse")]
  public class ExportActualPerpetualOvertimeHourTotalsListForEmployeeListResponse
  {
    [XmlArray(ElementName = "exportedPerpetualOvertimeHourTotals", IsNullable = false, Order = 0)]
    public List<PerpetualOvertimeHourTotal> ExportedPerpetualOvertimeHourTotals { get; set; }
  }
}
