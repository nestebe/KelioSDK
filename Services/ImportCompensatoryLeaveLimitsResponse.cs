
//.ImportCompensatoryLeaveLimitsResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importCompensatoryLeaveLimitsResponse")]
  public class ImportCompensatoryLeaveLimitsResponse
  {
    [XmlArray(ElementName = "compensatoryLeaveLimitsInError", IsNullable = false, Order = 0)]
    public List<CompensatoryLeaveLimit> CompensatoryLeaveLimitsInError { get; set; }
  }
}
