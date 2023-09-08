
//.ImportCoreWindowsResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importCoreWindowsResponse")]
  public class ImportCoreWindowsResponse
  {
    [XmlArray(ElementName = "coreWindowsInError", IsNullable = false, Order = 0)]
    public List<CoreWindow> CoreWindowsInError { get; set; }
  }
}
