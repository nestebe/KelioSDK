
//.ImportClockingAllowanceWindows




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importClockingAllowanceWindows")]
  public class ImportClockingAllowanceWindows
  {
    [XmlArray(ElementName = "clockingAllowanceWindowsToImport", IsNullable = false, Order = 0)]
    public List<ClockingAllowanceWindow> ClockingAllowanceWindowsToImport { get; set; }
  }
}
