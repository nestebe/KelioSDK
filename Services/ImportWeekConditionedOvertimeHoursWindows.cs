
//.ImportWeekConditionedOvertimeHoursWindows




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importWeekConditionedOvertimeHoursWindows")]
  public class ImportWeekConditionedOvertimeHoursWindows
  {
    [XmlArray(ElementName = "weekConditionedOvertimeHoursWindowsToImport", IsNullable = false, Order = 0)]
    public List<WeekConditionedOvertimeHoursWindow> WeekConditionedOvertimeHoursWindowsToImport { get; set; }
  }
}
