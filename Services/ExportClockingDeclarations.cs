
//.ExportClockingDeclarations




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportClockingDeclarations")]
  public class ExportClockingDeclarations
  {
    [XmlArray(ElementName = "exportFilter", IsNullable = false, Order = 0)]
    public List<AskedClockingDeclaration> ExportFilter { get; set; }
  }
}
