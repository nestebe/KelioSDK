
//.ExportBreakWindowsListResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportBreakWindowsListResponse")]
  public class ExportBreakWindowsListResponse
  {
    [XmlArray(ElementName = "exportedBreakWindows", IsNullable = false, Order = 0)]
    public List<BreakWindow> ExportedBreakWindows { get; set; }
  }
}
