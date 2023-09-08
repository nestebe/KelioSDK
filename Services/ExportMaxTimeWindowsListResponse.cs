
//.ExportMaxTimeWindowsListResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportMaxTimeWindowsListResponse")]
  public class ExportMaxTimeWindowsListResponse
  {
    [XmlArray(ElementName = "exportedMaxTimeWindows", IsNullable = false, Order = 0)]
    public List<MaxTimeWindow> ExportedMaxTimeWindows { get; set; }
  }
}
