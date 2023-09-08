
//.ExportNonActualPaidBreakWindowsResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportNonActualPaidBreakWindowsResponse")]
  public class ExportNonActualPaidBreakWindowsResponse
  {
    [XmlArray(ElementName = "exportedNonActualPaidBreakWindows", IsNullable = false, Order = 0)]
    public List<NonActualPaidBreakWindow> ExportedNonActualPaidBreakWindows { get; set; }
  }
}
