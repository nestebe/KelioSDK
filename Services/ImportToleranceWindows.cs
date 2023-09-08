
//.ImportToleranceWindows




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importToleranceWindows")]
  public class ImportToleranceWindows
  {
    [XmlArray(ElementName = "toleranceWindowsToImport", IsNullable = false, Order = 0)]
    public List<ToleranceWindow> ToleranceWindowsToImport { get; set; }
  }
}
