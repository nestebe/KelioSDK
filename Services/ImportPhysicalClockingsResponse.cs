
//.ImportPhysicalClockingsResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importPhysicalClockingsResponse")]
  public class ImportPhysicalClockingsResponse
  {
    [XmlArray(ElementName = "clockingsInError", IsNullable = false, Order = 0)]
    public List<Clocking> ClockingsInError { get; set; }
  }
}
