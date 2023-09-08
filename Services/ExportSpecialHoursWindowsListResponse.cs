
//.ExportSpecialHoursWindowsListResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportSpecialHoursWindowsListResponse")]
  public class ExportSpecialHoursWindowsListResponse
  {
    [XmlArray(ElementName = "exportedSpecialHoursWindows", IsNullable = false, Order = 0)]
    public List<SpecialHoursWindow> ExportedSpecialHoursWindows { get; set; }
  }
}
