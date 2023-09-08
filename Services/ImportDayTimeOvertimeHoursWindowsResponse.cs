
//.ImportDayTimeOvertimeHoursWindowsResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importDayTimeOvertimeHoursWindowsResponse")]
  public class ImportDayTimeOvertimeHoursWindowsResponse
  {
    [XmlArray(ElementName = "dayTimeOvertimeHoursWindowsInError", IsNullable = false, Order = 0)]
    public List<DayTimeOvertimeHoursWindow> DayTimeOvertimeHoursWindowsInError { get; set; }
  }
}
