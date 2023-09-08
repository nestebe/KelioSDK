
//.ImportMaxTimeWindowsResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importMaxTimeWindowsResponse")]
  public class ImportMaxTimeWindowsResponse
  {
    [XmlArray(ElementName = "maxTimeWindowsInError", IsNullable = false, Order = 0)]
    public List<MaxTimeWindow> MaxTimeWindowsInError { get; set; }
  }
}
