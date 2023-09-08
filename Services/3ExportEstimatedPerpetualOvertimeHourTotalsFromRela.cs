
//.ExportEstimatedPerpetualOvertimeHourTotalsFromRelativeDatesResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportEstimatedPerpetualOvertimeHourTotalsFromRelativeDatesResponse")]
  public class ExportEstimatedPerpetualOvertimeHourTotalsFromRelativeDatesResponse
  {
    [XmlArray(ElementName = "exportedPerpetualOvertimeHourTotals", IsNullable = false, Order = 0)]
    public List<PerpetualOvertimeHourTotal> ExportedPerpetualOvertimeHourTotals { get; set; }
  }
}
