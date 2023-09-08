
//.ImportWeekConditionedOvertimeHoursWindowsResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importWeekConditionedOvertimeHoursWindowsResponse")]
  public class ImportWeekConditionedOvertimeHoursWindowsResponse
  {
    [XmlArray(ElementName = "weekConditionedOvertimeHoursWindowsInError", IsNullable = false, Order = 0)]
    public List<WeekConditionedOvertimeHoursWindow> WeekConditionedOvertimeHoursWindowsInError { get; set; }
  }
}
