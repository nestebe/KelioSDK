
//.ExportHourlyRatesListResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportHourlyRatesListResponse")]
  public class ExportHourlyRatesListResponse
  {
    [XmlArray(ElementName = "exportedHourlyRates", IsNullable = false, Order = 0)]
    public List<HourlyRate> ExportedHourlyRates { get; set; }
  }
}
