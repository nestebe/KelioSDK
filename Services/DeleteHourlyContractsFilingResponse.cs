
//.DeleteHourlyContractsFilingResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "deleteHourlyContractsFilingResponse")]
  public class DeleteHourlyContractsFilingResponse
  {
    [XmlArray(ElementName = "hourlyContractsFilingInError", IsNullable = false, Order = 0)]
    public List<Filing> HourlyContractsFilingInError { get; set; }
  }
}
