
//.DeleteHourlyContractsFiling




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "deleteHourlyContractsFiling")]
  public class DeleteHourlyContractsFiling
  {
    [XmlArray(ElementName = "hourlyContractsFilingToDelete", IsNullable = false, Order = 0)]
    public List<Filing> HourlyContractsFilingToDelete { get; set; }
  }
}
