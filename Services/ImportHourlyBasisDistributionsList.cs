
//.ImportHourlyBasisDistributionsList




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importHourlyBasisDistributionsList")]
  public class ImportHourlyBasisDistributionsList
  {
    [XmlArray(ElementName = "hourlyBasisDistributionsListToImport", IsNullable = false, Order = 0)]
    public List<HourlyBasisDistribution> HourlyBasisDistributionsListToImport { get; set; }
  }
}
