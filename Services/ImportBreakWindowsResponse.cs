
//.ImportBreakWindowsResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importBreakWindowsResponse")]
  public class ImportBreakWindowsResponse
  {
    [XmlArray(ElementName = "breakWindowsInError", IsNullable = false, Order = 0)]
    public List<BreakWindow> BreakWindowsInError { get; set; }
  }
}
