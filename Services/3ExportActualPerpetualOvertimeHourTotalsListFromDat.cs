
//.ExportActualPerpetualOvertimeHourTotalsListFromDateResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportActualPerpetualOvertimeHourTotalsListFromDateResponse")]
  public class ExportActualPerpetualOvertimeHourTotalsListFromDateResponse
  {
    [XmlArray(ElementName = "exportedPerpetualOvertimeHourTotals", IsNullable = false, Order = 0)]
    public List<PerpetualOvertimeHourTotal> ExportedPerpetualOvertimeHourTotals { get; set; }
  }
}
