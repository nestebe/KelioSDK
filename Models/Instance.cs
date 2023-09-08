
// Type: KelioSDK.Models.Instance




using KelioSDK.Common;
using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "Instance")]
  public class Instance : ObjectBase
  {
    [XmlElement(DataType = "int", ElementName = "exitValue", IsNullable = true)]
    public int? ExitValue { get; set; }

    [XmlElement(DataType = "string", ElementName = "instanceDescription", IsNullable = true)]
    public string InstanceDescription { get; set; }

    [XmlElement(DataType = "string", ElementName = "userLogin", IsNullable = true)]
    public string UserLogin { get; set; }

    [XmlElement(DataType = "string", ElementName = "populationDescription", IsNullable = true)]
    public string PopulationDescription { get; set; }

    [XmlElement(DataType = "string", ElementName = "parameterValue05", IsNullable = true)]
    public string ParameterValue05 { get; set; }

    [XmlElement(DataType = "string", ElementName = "parameterValue03", IsNullable = true)]
    public string ParameterValue03 { get; set; }

    [XmlElement(DataType = "string", ElementName = "parameterName03", IsNullable = true)]
    public string ParameterName03 { get; set; }

    [XmlElement(DataType = "string", ElementName = "parameterName05", IsNullable = true)]
    public string ParameterName05 { get; set; }

    [XmlElement(DataType = "string", ElementName = "parameterName02", IsNullable = true)]
    public string ParameterName02 { get; set; }

    [XmlElement(DataType = "string", ElementName = "parameterValue02", IsNullable = true)]
    public string ParameterValue02 { get; set; }

    [XmlElement(DataType = "string", ElementName = "parameterValue04", IsNullable = true)]
    public string ParameterValue04 { get; set; }

    [XmlElement(DataType = "string", ElementName = "parameterName04", IsNullable = true)]
    public string ParameterName04 { get; set; }

    [XmlElement(DataType = "string", ElementName = "parameterValue06", IsNullable = true)]
    public string ParameterValue06 { get; set; }

    [XmlElement(DataType = "string", ElementName = "parameterName07", IsNullable = true)]
    public string ParameterName07 { get; set; }

    [XmlElement(DataType = "string", ElementName = "parameterValue07", IsNullable = true)]
    public string ParameterValue07 { get; set; }

    [XmlElement(DataType = "string", ElementName = "parameterName06", IsNullable = true)]
    public string ParameterName06 { get; set; }

    [XmlElement(DataType = "string", ElementName = "parameterName08", IsNullable = true)]
    public string ParameterName08 { get; set; }

    [XmlElement(DataType = "string", ElementName = "parameterName01", IsNullable = true)]
    public string ParameterName01 { get; set; }

    [XmlElement(DataType = "string", ElementName = "parameterValue01", IsNullable = true)]
    public string ParameterValue01 { get; set; }

    [XmlElement(DataType = "string", ElementName = "parameterName10", IsNullable = true)]
    public string ParameterName10 { get; set; }

    [XmlElement(DataType = "double", ElementName = "executionTime", IsNullable = true)]
    public double? ExecutionTime { get; set; }

    [XmlElement(DataType = "string", ElementName = "parameterValue10", IsNullable = true)]
    public string ParameterValue10 { get; set; }

    [XmlElement(DataType = "string", ElementName = "parameterValue09", IsNullable = true)]
    public string ParameterValue09 { get; set; }

    [XmlElement(DataType = "string", ElementName = "executionHome", IsNullable = true)]
    public string ExecutionHome { get; set; }

    [XmlElement(DataType = "string", ElementName = "executionLog", IsNullable = true)]
    public string ExecutionLog { get; set; }

    [XmlElement(DataType = "string", ElementName = "parameterName09", IsNullable = true)]
    public string ParameterName09 { get; set; }

    [XmlElement(DataType = "string", ElementName = "parameterValue08", IsNullable = true)]
    public string ParameterValue08 { get; set; }
  }
}
