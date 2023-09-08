
//.ImportBonusWindows




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importBonusWindows")]
  public class ImportBonusWindows
  {
    [XmlArray(ElementName = "bonusWindowsToImport", IsNullable = false, Order = 0)]
    public List<BonusWindow> BonusWindowsToImport { get; set; }
  }
}
