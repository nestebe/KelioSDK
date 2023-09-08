
//.ImportSpecialHoursWindows




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importSpecialHoursWindows")]
  public class ImportSpecialHoursWindows
  {
    [XmlArray(ElementName = "specialHoursWindowsToImport", IsNullable = false, Order = 0)]
    public List<SpecialHoursWindow> SpecialHoursWindowsToImport { get; set; }
  }
}
