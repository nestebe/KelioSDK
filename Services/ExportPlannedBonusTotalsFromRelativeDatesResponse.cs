
//.ExportPlannedBonusTotalsFromRelativeDatesResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportPlannedBonusTotalsFromRelativeDatesResponse")]
  public class ExportPlannedBonusTotalsFromRelativeDatesResponse
  {
    [XmlArray(ElementName = "exportedFromDateToDateBonusTotals", IsNullable = false, Order = 0)]
    public List<FromDateToDateBonusTotal> ExportedFromDateToDateBonusTotals { get; set; }
  }
}
