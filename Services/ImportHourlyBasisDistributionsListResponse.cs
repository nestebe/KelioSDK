
//.ImportHourlyBasisDistributionsListResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importHourlyBasisDistributionsListResponse")]
  public class ImportHourlyBasisDistributionsListResponse
  {
    [XmlArray(ElementName = "hourlyBasisDistributionsListInError", IsNullable = false, Order = 0)]
    public List<HourlyBasisDistribution> HourlyBasisDistributionsListInError { get; set; }
  }
}
