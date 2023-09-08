
//.ImportStandardHoursWindowsResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importStandardHoursWindowsResponse")]
  public class ImportStandardHoursWindowsResponse
  {
    [XmlArray(ElementName = "standardHoursWindowsInError", IsNullable = false, Order = 0)]
    public List<StandardHoursWindow> StandardHoursWindowsInError { get; set; }
  }
}
