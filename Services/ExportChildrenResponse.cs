
//.ExportChildrenResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportChildrenResponse")]
  public class ExportChildrenResponse
  {
    [XmlArray(ElementName = "exportedChildren", IsNullable = false, Order = 0)]
    public List<Child> ExportedChildren { get; set; }
  }
}
