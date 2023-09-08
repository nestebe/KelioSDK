
//.ExportPlannedPerpetualBalanceTotalsFromRelativeDatesResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportPlannedPerpetualBalanceTotalsFromRelativeDatesResponse")]
  public class ExportPlannedPerpetualBalanceTotalsFromRelativeDatesResponse
  {
    [XmlArray(ElementName = "exportedPerpetualBalanceTotals", IsNullable = false, Order = 0)]
    public List<PerpetualBalanceTotal> ExportedPerpetualBalanceTotals { get; set; }
  }
}
