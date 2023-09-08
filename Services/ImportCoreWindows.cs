
//.ImportCoreWindows




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importCoreWindows")]
  public class ImportCoreWindows
  {
    [XmlArray(ElementName = "coreWindowsToImport", IsNullable = false, Order = 0)]
    public List<CoreWindow> CoreWindowsToImport { get; set; }
  }
}
