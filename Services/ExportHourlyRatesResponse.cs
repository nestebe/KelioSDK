
//.ExportHourlyRatesResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportHourlyRatesResponse")]
  public class ExportHourlyRatesResponse
  {
    [XmlArray(ElementName = "exportedHourlyRates", IsNullable = false, Order = 0)]
    public List<HourlyRate> ExportedHourlyRates { get; set; }
  }
}
