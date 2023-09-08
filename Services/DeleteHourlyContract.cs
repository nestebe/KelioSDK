
//.DeleteHourlyContract




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "deleteHourlyContract")]
  public class DeleteHourlyContract
  {
    [XmlArray(ElementName = "hourlyContractToDelete", IsNullable = false, Order = 0)]
    public List<HourlyContract> HourlyContractToDelete { get; set; }
  }
}
