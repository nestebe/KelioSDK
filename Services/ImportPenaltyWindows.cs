
//.ImportPenaltyWindows




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importPenaltyWindows")]
  public class ImportPenaltyWindows
  {
    [XmlArray(ElementName = "penaltyWindowsToImport", IsNullable = false, Order = 0)]
    public List<PenaltyWindow> PenaltyWindowsToImport { get; set; }
  }
}
