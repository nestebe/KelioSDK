
//.ExportToleranceWindowsResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportToleranceWindowsResponse")]
  public class ExportToleranceWindowsResponse
  {
    [XmlArray(ElementName = "exportedToleranceWindows", IsNullable = false, Order = 0)]
    public List<ToleranceWindow> ExportedToleranceWindows { get; set; }
  }
}
