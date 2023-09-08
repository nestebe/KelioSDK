
//.ImportBreakWindows




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importBreakWindows")]
  public class ImportBreakWindows
  {
    [XmlArray(ElementName = "breakWindowsToImport", IsNullable = false, Order = 0)]
    public List<BreakWindow> BreakWindowsToImport { get; set; }
  }
}
