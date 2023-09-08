
//.ExportBodetAppsFilingResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportBodetAppsFilingResponse")]
  public class ExportBodetAppsFilingResponse
  {
    [XmlArray(ElementName = "exportedBodetAppsFiling", IsNullable = false, Order = 0)]
    public List<Filing> ExportedBodetAppsFiling { get; set; }
  }
}
