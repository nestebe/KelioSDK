
//.ExportIconsResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportIconsResponse")]
  public class ExportIconsResponse
  {
    [XmlArray(ElementName = "exportedIcons", IsNullable = false, Order = 0)]
    public List<Icon> ExportedIcons { get; set; }
  }
}
