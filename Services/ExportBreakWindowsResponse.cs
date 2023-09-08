
//.ExportBreakWindowsResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportBreakWindowsResponse")]
  public class ExportBreakWindowsResponse
  {
    [XmlArray(ElementName = "exportedBreakWindows", IsNullable = false, Order = 0)]
    public List<BreakWindow> ExportedBreakWindows { get; set; }
  }
}
