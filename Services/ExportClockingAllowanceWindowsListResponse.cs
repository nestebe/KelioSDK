
//.ExportClockingAllowanceWindowsListResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportClockingAllowanceWindowsListResponse")]
  public class ExportClockingAllowanceWindowsListResponse
  {
    [XmlArray(ElementName = "exportedClockingAllowanceWindows", IsNullable = false, Order = 0)]
    public List<ClockingAllowanceWindow> ExportedClockingAllowanceWindows { get; set; }
  }
}
