
//.ImportHourlyRatesResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importHourlyRatesResponse")]
  public class ImportHourlyRatesResponse
  {
    [XmlArray(ElementName = "hourlyRatesInError", IsNullable = false, Order = 0)]
    public List<HourlyRate> HourlyRatesInError { get; set; }
  }
}
