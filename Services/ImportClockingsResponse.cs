
//.ImportClockingsResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importClockingsResponse")]
  public class ImportClockingsResponse
  {
    [XmlArray(ElementName = "clockingsInError", IsNullable = false, Order = 0)]
    public List<Clocking> ClockingsInError { get; set; }
  }
}
