
//.ExportActivityFilingResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportActivityFilingResponse")]
  public class ExportActivityFilingResponse
  {
    [XmlArray(ElementName = "exportedActivityFiling", IsNullable = false, Order = 0)]
    public List<Filing> ExportedActivityFiling { get; set; }
  }
}
