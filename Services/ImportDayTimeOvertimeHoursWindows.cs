
//.ImportDayTimeOvertimeHoursWindows




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importDayTimeOvertimeHoursWindows")]
  public class ImportDayTimeOvertimeHoursWindows
  {
    [XmlArray(ElementName = "dayTimeOvertimeHoursWindowsToImport", IsNullable = false, Order = 0)]
    public List<DayTimeOvertimeHoursWindow> DayTimeOvertimeHoursWindowsToImport { get; set; }
  }
}
