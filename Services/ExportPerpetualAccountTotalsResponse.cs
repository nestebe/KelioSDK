
//.ExportPerpetualAccountTotalsResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportPerpetualAccountTotalsResponse")]
  public class ExportPerpetualAccountTotalsResponse
  {
    [XmlArray(ElementName = "exportedPerpetualAccountTotals", IsNullable = false, Order = 0)]
    public List<PerpetualTotal> ExportedPerpetualAccountTotals { get; set; }
  }
}
