
//.ExportClockingDeclarationsResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportClockingDeclarationsResponse")]
  public class ExportClockingDeclarationsResponse
  {
    [XmlArray(ElementName = "exportedClockingDeclarations", IsNullable = false, Order = 0)]
    public List<ClockingDeclaration> ExportedClockingDeclarations { get; set; }
  }
}
