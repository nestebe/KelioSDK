
//.ExportCyclicalOvertimeHourTotalsResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportCyclicalOvertimeHourTotalsResponse")]
  public class ExportCyclicalOvertimeHourTotalsResponse
  {
    [XmlArray(ElementName = "exportedCyclicalOvertimeHourTotals", IsNullable = false, Order = 0)]
    public List<CyclicalOvertimeHourTotal> ExportedCyclicalOvertimeHourTotals { get; set; }
  }
}
