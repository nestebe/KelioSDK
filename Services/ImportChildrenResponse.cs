
//.ImportChildrenResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importChildrenResponse")]
  public class ImportChildrenResponse
  {
    [XmlArray(ElementName = "childrenInError", IsNullable = false, Order = 0)]
    public List<Child> ChildrenInError { get; set; }
  }
}
