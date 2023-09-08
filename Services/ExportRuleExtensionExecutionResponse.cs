
//.ExportRuleExtensionExecutionResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportRuleExtensionExecutionResponse")]
  public class ExportRuleExtensionExecutionResponse
  {
    [XmlArray(ElementName = "exportedRuleExtensionExecution", IsNullable = false, Order = 0)]
    public List<RuleExtensionExecution> ExportedRuleExtensionExecution { get; set; }
  }
}
