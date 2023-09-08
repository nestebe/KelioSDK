
//.ExportAnomaliesListResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportAnomaliesListResponse")]
  public class ExportAnomaliesListResponse
  {
    [XmlArray(ElementName = "exportedAnomalies", IsNullable = false, Order = 0)]
    public List<Anomaly> ExportedAnomalies { get; set; }
  }
}
