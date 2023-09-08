
//.ExportEstimatedPerpetualOnCallDutyTotalsListForEmployeeListResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportEstimatedPerpetualOnCallDutyTotalsListForEmployeeListResponse")]
  public class ExportEstimatedPerpetualOnCallDutyTotalsListForEmployeeListResponse
  {
    [XmlArray(ElementName = "exportedPerpetualOnCallDutyTotals", IsNullable = false, Order = 0)]
    public List<PerpetualOnCallDutyTotal> ExportedPerpetualOnCallDutyTotals { get; set; }
  }
}
