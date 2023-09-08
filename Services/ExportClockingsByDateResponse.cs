
//.ExportClockingsByDateResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportClockingsByDateResponse")]
  public class ExportClockingsByDateResponse
  {
    [XmlArray(ElementName = "exportedClockings", IsNullable = false, Order = 0)]
    public List<Clocking> ExportedClockings { get; set; }
  }
}
