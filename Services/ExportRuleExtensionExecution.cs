
//.ExportRuleExtensionExecution




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportRuleExtensionExecution")]
  public class ExportRuleExtensionExecution
  {
    [XmlArray(ElementName = "exportFilter", IsNullable = false, Order = 0)]
    public List<RuleExtensionExecutionFilter> ExportFilter { get; set; }
  }
}
