
//.ExportTimeOffInLieuWindowsListResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportTimeOffInLieuWindowsListResponse")]
  public class ExportTimeOffInLieuWindowsListResponse
  {
    [XmlArray(ElementName = "exportedTimeOffInLieuWindows", IsNullable = false, Order = 0)]
    public List<TimeOffInLieuWindow> ExportedTimeOffInLieuWindows { get; set; }
  }
}
