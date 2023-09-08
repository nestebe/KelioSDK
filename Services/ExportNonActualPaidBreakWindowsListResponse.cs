
//.ExportNonActualPaidBreakWindowsListResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportNonActualPaidBreakWindowsListResponse")]
  public class ExportNonActualPaidBreakWindowsListResponse
  {
    [XmlArray(ElementName = "exportedNonActualPaidBreakWindows", IsNullable = false, Order = 0)]
    public List<NonActualPaidBreakWindow> ExportedNonActualPaidBreakWindows { get; set; }
  }
}
