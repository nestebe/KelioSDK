
//.ExportRoundingOnClockingWindowsListResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportRoundingOnClockingWindowsListResponse")]
  public class ExportRoundingOnClockingWindowsListResponse
  {
    [XmlArray(ElementName = "exportedRoundingOnClockingWindows", IsNullable = false, Order = 0)]
    public List<RoundingOnClockingWindow> ExportedRoundingOnClockingWindows { get; set; }
  }
}
