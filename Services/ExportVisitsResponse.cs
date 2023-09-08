
//.ExportVisitsResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportVisitsResponse")]
  public class ExportVisitsResponse
  {
    [XmlArray(ElementName = "exportedVisits", IsNullable = false, Order = 0)]
    public List<Visit> ExportedVisits { get; set; }
  }
}
