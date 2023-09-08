
//.ExportHourlyBasisDistributionsListResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportHourlyBasisDistributionsListResponse")]
  public class ExportHourlyBasisDistributionsListResponse
  {
    [XmlArray(ElementName = "exportedHourlyBasisDistributionsList", IsNullable = false, Order = 0)]
    public List<HourlyBasisDistribution> ExportedHourlyBasisDistributionsList { get; set; }
  }
}
