
//.ImportHourlyContractsFilingResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importHourlyContractsFilingResponse")]
  public class ImportHourlyContractsFilingResponse
  {
    [XmlArray(ElementName = "hourlyContractsFilingInError", IsNullable = false, Order = 0)]
    public List<Filing> HourlyContractsFilingInError { get; set; }
  }
}
