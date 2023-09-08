
//.DeletePhysicalClockings




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "deletePhysicalClockings")]
  public class DeletePhysicalClockings
  {
    [XmlArray(ElementName = "clockingsToDelete", IsNullable = false, Order = 0)]
    public List<Clocking> ClockingsToDelete { get; set; }
  }
}
