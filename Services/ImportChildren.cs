
//.ImportChildren




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importChildren")]
  public class ImportChildren
  {
    [XmlArray(ElementName = "childrenToImport", IsNullable = false, Order = 0)]
    public List<Child> ChildrenToImport { get; set; }
  }
}
