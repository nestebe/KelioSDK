
//.ImportHourlyContract




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importHourlyContract")]
  public class ImportHourlyContract
  {
    [XmlArray(ElementName = "hourlyContractToImport", IsNullable = false, Order = 0)]
    public List<HourlyContract> HourlyContractToImport { get; set; }
  }
}
