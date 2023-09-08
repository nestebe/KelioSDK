
//.ExportActualPerpetualAbsenceTotalsFromRelativeDatesResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportActualPerpetualAbsenceTotalsFromRelativeDatesResponse")]
  public class ExportActualPerpetualAbsenceTotalsFromRelativeDatesResponse
  {
    [XmlArray(ElementName = "exportedPerpetualAbsenceTotals", IsNullable = false, Order = 0)]
    public List<PerpetualAbsenceTotal> ExportedPerpetualAbsenceTotals { get; set; }
  }
}
