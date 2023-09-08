
//.ExportActualPerpetualOnCallDutyTotalsListFromDateResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportActualPerpetualOnCallDutyTotalsListFromDateResponse")]
  public class ExportActualPerpetualOnCallDutyTotalsListFromDateResponse
  {
    [XmlArray(ElementName = "exportedPerpetualOnCallDutyTotals", IsNullable = false, Order = 0)]
    public List<PerpetualOnCallDutyTotal> ExportedPerpetualOnCallDutyTotals { get; set; }
  }
}
