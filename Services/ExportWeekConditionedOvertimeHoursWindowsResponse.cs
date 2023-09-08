
//.ExportWeekConditionedOvertimeHoursWindowsResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportWeekConditionedOvertimeHoursWindowsResponse")]
  public class ExportWeekConditionedOvertimeHoursWindowsResponse
  {
    [XmlArray(ElementName = "exportedWeekConditionedOvertimeHoursWindows", IsNullable = false, Order = 0)]
    public List<WeekConditionedOvertimeHoursWindow> ExportedWeekConditionedOvertimeHoursWindows { get; set; }
  }
}
