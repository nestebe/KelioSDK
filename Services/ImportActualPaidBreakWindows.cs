
//.ImportActualPaidBreakWindows




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importActualPaidBreakWindows")]
  public class ImportActualPaidBreakWindows
  {
    [XmlArray(ElementName = "actualPaidBreakWindowsToImport", IsNullable = false, Order = 0)]
    public List<ActualPaidBreakWindow> ActualPaidBreakWindowsToImport { get; set; }
  }
}
