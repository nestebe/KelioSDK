
//.ExportDailyScheduleWindowsResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportDailyScheduleWindowsResponse")]
  public class ExportDailyScheduleWindowsResponse
  {
    [XmlArray(ElementName = "exportedDailyScheduleWindows", IsNullable = false, Order = 0)]
    public List<DailyScheduleWindow> ExportedDailyScheduleWindows { get; set; }
  }
}
