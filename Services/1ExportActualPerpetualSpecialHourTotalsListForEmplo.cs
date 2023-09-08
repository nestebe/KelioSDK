
//.ExportActualPerpetualSpecialHourTotalsListForEmployeeListResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportActualPerpetualSpecialHourTotalsListForEmployeeListResponse")]
  public class ExportActualPerpetualSpecialHourTotalsListForEmployeeListResponse
  {
    [XmlArray(ElementName = "exportedPerpetualSpecialHourTotals", IsNullable = false, Order = 0)]
    public List<PerpetualSpecialHourTotal> ExportedPerpetualSpecialHourTotals { get; set; }
  }
}
