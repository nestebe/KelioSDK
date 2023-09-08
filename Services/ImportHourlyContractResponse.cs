
//.ImportHourlyContractResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importHourlyContractResponse")]
  public class ImportHourlyContractResponse
  {
    [XmlArray(ElementName = "hourlyContractInError", IsNullable = false, Order = 0)]
    public List<HourlyContract> HourlyContractInError { get; set; }
  }
}
