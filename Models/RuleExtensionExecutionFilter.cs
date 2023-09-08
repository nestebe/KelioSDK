
// Type: KelioSDK.Models.RuleExtensionExecutionFilter




using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "RuleExtensionExecutionFilter")]
  public class RuleExtensionExecutionFilter : AskedPopulationWithPeriod
  {
    [XmlElement(DataType = "short", ElementName = "executionTypeFilter", IsNullable = true)]
    public short? ExecutionTypeFilter { get; set; }

    [XmlElement(DataType = "string", ElementName = "ruleExtensionStateFilter", IsNullable = true)]
    public string RuleExtensionStateFilter { get; set; }

    [XmlElement(DataType = "string", ElementName = "instanceDescriptionFilter", IsNullable = true)]
    public string InstanceDescriptionFilter { get; set; }

    [XmlElement(DataType = "string", ElementName = "tabVisibilityFilter", IsNullable = true)]
    public string TabVisibilityFilter { get; set; }

    [XmlElement(DataType = "string", ElementName = "tabIdentifierFilter", IsNullable = true)]
    public string TabIdentifierFilter { get; set; }

    [XmlElement(DataType = "string", ElementName = "parameterIdentifierFilter", IsNullable = true)]
    public string ParameterIdentifierFilter { get; set; }

    [XmlElement(DataType = "string", ElementName = "instanceKeyFilter", IsNullable = true)]
    public string InstanceKeyFilter { get; set; }
  }
}
