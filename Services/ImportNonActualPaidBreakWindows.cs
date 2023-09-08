
//.ImportNonActualPaidBreakWindows




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importNonActualPaidBreakWindows")]
  public class ImportNonActualPaidBreakWindows
  {
    [XmlArray(ElementName = "nonActualPaidBreakWindowsToImport", IsNullable = false, Order = 0)]
    public List<NonActualPaidBreakWindow> NonActualPaidBreakWindowsToImport { get; set; }
  }
}
