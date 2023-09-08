
//.ExportActualPerpetualBonusTotalsFromRelativeDatesResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportActualPerpetualBonusTotalsFromRelativeDatesResponse")]
  public class ExportActualPerpetualBonusTotalsFromRelativeDatesResponse
  {
    [XmlArray(ElementName = "exportedPerpetualBonusTotals", IsNullable = false, Order = 0)]
    public List<PerpetualBonusTotal> ExportedPerpetualBonusTotals { get; set; }
  }
}
