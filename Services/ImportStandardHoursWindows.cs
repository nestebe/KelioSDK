
//.ImportStandardHoursWindows




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importStandardHoursWindows")]
  public class ImportStandardHoursWindows
  {
    [XmlArray(ElementName = "standardHoursWindowsToImport", IsNullable = false, Order = 0)]
    public List<StandardHoursWindow> StandardHoursWindowsToImport { get; set; }
  }
}
