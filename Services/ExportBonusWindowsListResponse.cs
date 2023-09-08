
//.ExportBonusWindowsListResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportBonusWindowsListResponse")]
  public class ExportBonusWindowsListResponse
  {
    [XmlArray(ElementName = "exportedBonusWindows", IsNullable = false, Order = 0)]
    public List<BonusWindow> ExportedBonusWindows { get; set; }
  }
}
