
//.ImportRoundingOnClockingWindows




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importRoundingOnClockingWindows")]
  public class ImportRoundingOnClockingWindows
  {
    [XmlArray(ElementName = "roundingOnClockingWindowsToImport", IsNullable = false, Order = 0)]
    public List<RoundingOnClockingWindow> RoundingOnClockingWindowsToImport { get; set; }
  }
}
