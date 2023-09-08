
//.ExportActualPerpetualOnCallDutyTotalsListResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportActualPerpetualOnCallDutyTotalsListResponse")]
  public class ExportActualPerpetualOnCallDutyTotalsListResponse
  {
    [XmlArray(ElementName = "exportedPerpetualOnCallDutyTotals", IsNullable = false, Order = 0)]
    public List<PerpetualOnCallDutyTotal> ExportedPerpetualOnCallDutyTotals { get; set; }
  }
}
