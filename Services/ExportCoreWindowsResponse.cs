
//.ExportCoreWindowsResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportCoreWindowsResponse")]
  public class ExportCoreWindowsResponse
  {
    [XmlArray(ElementName = "exportedCoreWindows", IsNullable = false, Order = 0)]
    public List<CoreWindow> ExportedCoreWindows { get; set; }
  }
}
