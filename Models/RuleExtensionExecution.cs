
// Type: KelioSDK.Models.RuleExtensionExecution




using System;
using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "RuleExtensionExecution")]
  public class RuleExtensionExecution : EmployeeInformation
  {
    [XmlElement(DataType = "date", ElementName = "date", IsNullable = true)]
    public DateTime? Date { get; set; }

    [XmlElement(DataType = "string", ElementName = "parameterValueDescription", IsNullable = true)]
    public string ParameterValueDescription { get; set; }

    [XmlElement(DataType = "short", ElementName = "executionType", IsNullable = true)]
    public short? ExecutionType { get; set; }

    [XmlElement(DataType = "string", ElementName = "parameterDescription", IsNullable = true)]
    public string ParameterDescription { get; set; }

    [XmlElement(DataType = "short", ElementName = "parameterFormat", IsNullable = true)]
    public short? ParameterFormat { get; set; }

    [XmlElement(DataType = "string", ElementName = "parameterValue", IsNullable = true)]
    public string ParameterValue { get; set; }

    [XmlElement(DataType = "short", ElementName = "ruleExtensionState", IsNullable = true)]
    public short? RuleExtensionState { get; set; }

    [XmlElement(DataType = "string", ElementName = "instanceDescription", IsNullable = true)]
    public string InstanceDescription { get; set; }

    [XmlElement(DataType = "short", ElementName = "parameterType", IsNullable = true)]
    public short? ParameterType { get; set; }

    [XmlElement(DataType = "string", ElementName = "parameterValueAbbreviation", IsNullable = true)]
    public string ParameterValueAbbreviation { get; set; }

    [XmlElement(DataType = "string", ElementName = "parameterValueKey", IsNullable = true)]
    public string ParameterValueKey { get; set; }

    [XmlElement(DataType = "int", ElementName = "parameterKey", IsNullable = true)]
    public int? ParameterKey { get; set; }

    [XmlElement(DataType = "string", ElementName = "parameterIdentifier", IsNullable = true)]
    public string ParameterIdentifier { get; set; }

    [XmlElement(DataType = "int", ElementName = "instanceKey", IsNullable = true)]
    public int? InstanceKey { get; set; }
  }
}
