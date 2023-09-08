
//.ExportFlexibleWindowsListResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportFlexibleWindowsListResponse")]
  public class ExportFlexibleWindowsListResponse
  {
    [XmlArray(ElementName = "exportedFlexibleWindows", IsNullable = false, Order = 0)]
    public List<FlexibleWindow> ExportedFlexibleWindows { get; set; }
  }
}
