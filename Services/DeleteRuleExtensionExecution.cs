
//.DeleteRuleExtensionExecution




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "deleteRuleExtensionExecution")]
  public class DeleteRuleExtensionExecution
  {
    [XmlArray(ElementName = "ruleExtensionExecutionToDelete", IsNullable = false, Order = 0)]
    public List<RuleExtensionExecution> RuleExtensionExecutionToDelete { get; set; }
  }
}
