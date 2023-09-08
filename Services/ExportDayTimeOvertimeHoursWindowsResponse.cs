
//.ExportDayTimeOvertimeHoursWindowsResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportDayTimeOvertimeHoursWindowsResponse")]
  public class ExportDayTimeOvertimeHoursWindowsResponse
  {
    [XmlArray(ElementName = "exportedDayTimeOvertimeHoursWindows", IsNullable = false, Order = 0)]
    public List<DayTimeOvertimeHoursWindow> ExportedDayTimeOvertimeHoursWindows { get; set; }
  }
}
