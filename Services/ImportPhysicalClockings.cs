
//.ImportPhysicalClockings




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importPhysicalClockings")]
  public class ImportPhysicalClockings
  {
    [XmlArray(ElementName = "clockingsToImport", IsNullable = false, Order = 0)]
    public List<Clocking> ClockingsToImport { get; set; }
  }
}
