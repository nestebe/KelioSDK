
//.ImportClockingAllowanceWindowsResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importClockingAllowanceWindowsResponse")]
  public class ImportClockingAllowanceWindowsResponse
  {
    [XmlArray(ElementName = "clockingAllowanceWindowsInError", IsNullable = false, Order = 0)]
    public List<ClockingAllowanceWindow> ClockingAllowanceWindowsInError { get; set; }
  }
}
