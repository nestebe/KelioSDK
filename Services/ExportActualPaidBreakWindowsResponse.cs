
//.ExportActualPaidBreakWindowsResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportActualPaidBreakWindowsResponse")]
  public class ExportActualPaidBreakWindowsResponse
  {
    [XmlArray(ElementName = "exportedActualPaidBreakWindows", IsNullable = false, Order = 0)]
    public List<ActualPaidBreakWindow> ExportedActualPaidBreakWindows { get; set; }
  }
}
