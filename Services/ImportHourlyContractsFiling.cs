
//.ImportHourlyContractsFiling




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importHourlyContractsFiling")]
  public class ImportHourlyContractsFiling
  {
    [XmlArray(ElementName = "hourlyContractsFilingToImport", IsNullable = false, Order = 0)]
    public List<Filing> HourlyContractsFilingToImport { get; set; }
  }
}
