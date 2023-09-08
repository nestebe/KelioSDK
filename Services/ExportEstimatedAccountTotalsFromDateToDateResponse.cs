
//.ExportEstimatedAccountTotalsFromDateToDateResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportEstimatedAccountTotalsFromDateToDateResponse")]
  public class ExportEstimatedAccountTotalsFromDateToDateResponse
  {
    [XmlArray(ElementName = "exportedFromDateToDateAccountTotals", IsNullable = false, Order = 0)]
    public List<FromDateToDateTotal> ExportedFromDateToDateAccountTotals { get; set; }
  }
}
