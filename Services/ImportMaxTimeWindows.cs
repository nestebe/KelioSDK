
//.ImportMaxTimeWindows




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importMaxTimeWindows")]
  public class ImportMaxTimeWindows
  {
    [XmlArray(ElementName = "maxTimeWindowsToImport", IsNullable = false, Order = 0)]
    public List<MaxTimeWindow> MaxTimeWindowsToImport { get; set; }
  }
}
