
//.ExportCalculatedClockingsOnlyResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportCalculatedClockingsOnlyResponse")]
  public class ExportCalculatedClockingsOnlyResponse
  {
    [XmlArray(ElementName = "exportedClockings", IsNullable = false, Order = 0)]
    public List<Clocking> ExportedClockings { get; set; }
  }
}
