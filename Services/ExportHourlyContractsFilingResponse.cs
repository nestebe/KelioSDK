
//.ExportHourlyContractsFilingResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportHourlyContractsFilingResponse")]
  public class ExportHourlyContractsFilingResponse
  {
    [XmlArray(ElementName = "exportedHourlyContractsFiling", IsNullable = false, Order = 0)]
    public List<Filing> ExportedHourlyContractsFiling { get; set; }
  }
}
