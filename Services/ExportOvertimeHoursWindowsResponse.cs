
//.ExportOvertimeHoursWindowsResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportOvertimeHoursWindowsResponse")]
  public class ExportOvertimeHoursWindowsResponse
  {
    [XmlArray(ElementName = "exportedOvertimeHoursWindows", IsNullable = false, Order = 0)]
    public List<OvertimeHoursWindow> ExportedOvertimeHoursWindows { get; set; }
  }
}
