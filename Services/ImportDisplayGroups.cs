
//.ImportDisplayGroups




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importDisplayGroups")]
  public class ImportDisplayGroups
  {
    [XmlArray(ElementName = "displayGroupsToImport", IsNullable = false, Order = 0)]
    public List<DisplayGroup> DisplayGroupsToImport { get; set; }
  }
}
