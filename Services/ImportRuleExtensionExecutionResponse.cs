
//.ImportRuleExtensionExecutionResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importRuleExtensionExecutionResponse")]
  public class ImportRuleExtensionExecutionResponse
  {
    [XmlArray(ElementName = "ruleExtensionExecutionInError", IsNullable = false, Order = 0)]
    public List<RuleExtensionExecution> RuleExtensionExecutionInError { get; set; }
  }
}
