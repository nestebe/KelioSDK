
//.ImportTimeOffInLieuWindows




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importTimeOffInLieuWindows")]
  public class ImportTimeOffInLieuWindows
  {
    [XmlArray(ElementName = "timeOffInLieuWindowsToImport", IsNullable = false, Order = 0)]
    public List<TimeOffInLieuWindow> TimeOffInLieuWindowsToImport { get; set; }
  }
}
