
//.ImportActualPaidBreakWindowsResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importActualPaidBreakWindowsResponse")]
  public class ImportActualPaidBreakWindowsResponse
  {
    [XmlArray(ElementName = "actualPaidBreakWindowsInError", IsNullable = false, Order = 0)]
    public List<ActualPaidBreakWindow> ActualPaidBreakWindowsInError { get; set; }
  }
}
