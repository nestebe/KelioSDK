
//.ImportCompensatoryLeaveLimits




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importCompensatoryLeaveLimits")]
  public class ImportCompensatoryLeaveLimits
  {
    [XmlArray(ElementName = "compensatoryLeaveLimitsToImport", IsNullable = false, Order = 0)]
    public List<CompensatoryLeaveLimit> CompensatoryLeaveLimitsToImport { get; set; }
  }
}
