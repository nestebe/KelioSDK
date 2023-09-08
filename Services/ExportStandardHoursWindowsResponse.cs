
//.ExportStandardHoursWindowsResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportStandardHoursWindowsResponse")]
  public class ExportStandardHoursWindowsResponse
  {
    [XmlArray(ElementName = "exportedStandardHoursWindows", IsNullable = false, Order = 0)]
    public List<StandardHoursWindow> ExportedStandardHoursWindows { get; set; }
  }
}
