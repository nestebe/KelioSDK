
//.ExportPerpetualGenericTotalsResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportPerpetualGenericTotalsResponse")]
  public class ExportPerpetualGenericTotalsResponse
  {
    [XmlArray(ElementName = "exportedPerpetualGenericTotals", IsNullable = false, Order = 0)]
    public List<PerpetualGenericTotal> ExportedPerpetualGenericTotals { get; set; }
  }
}
