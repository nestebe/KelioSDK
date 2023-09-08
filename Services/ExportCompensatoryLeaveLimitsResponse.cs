
//.ExportCompensatoryLeaveLimitsResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportCompensatoryLeaveLimitsResponse")]
  public class ExportCompensatoryLeaveLimitsResponse
  {
    [XmlArray(ElementName = "exportedCompensatoryLeaveLimits", IsNullable = false, Order = 0)]
    public List<CompensatoryLeaveLimit> ExportedCompensatoryLeaveLimits { get; set; }
  }
}
