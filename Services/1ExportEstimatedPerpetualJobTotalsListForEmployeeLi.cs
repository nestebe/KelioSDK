
//.ExportEstimatedPerpetualJobTotalsListForEmployeeListResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportEstimatedPerpetualJobTotalsListForEmployeeListResponse")]
  public class ExportEstimatedPerpetualJobTotalsListForEmployeeListResponse
  {
    [XmlArray(ElementName = "exportedPerpetualJobTotals", IsNullable = false, Order = 0)]
    public List<PerpetualJobTotal> ExportedPerpetualJobTotals { get; set; }
  }
}
