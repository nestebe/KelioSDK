
// Type: KelioSDK.Models.SpecificInterfaceParameter




using System;
using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "SpecificInterfaceParameter")]
  public class SpecificInterfaceParameter : EmployeeInformation
  {
    [XmlElement(DataType = "date", ElementName = "date", IsNullable = true)]
    public DateTime? Date { get; set; }

    [XmlElement(DataType = "string", ElementName = "parameterDescription", IsNullable = true)]
    public string ParameterDescription { get; set; }

    [XmlElement(DataType = "short", ElementName = "parameterFormat", IsNullable = true)]
    public short? ParameterFormat { get; set; }

    [XmlElement(DataType = "string", ElementName = "parameterAbbreviation", IsNullable = true)]
    public string ParameterAbbreviation { get; set; }

    [XmlElement(DataType = "string", ElementName = "parameterValue", IsNullable = true)]
    public string ParameterValue { get; set; }

    [XmlElement(DataType = "short", ElementName = "parameterType", IsNullable = true)]
    public short? ParameterType { get; set; }

    [XmlElement(DataType = "string", ElementName = "parameterKey", IsNullable = true)]
    public string ParameterKey { get; set; }

    [XmlElement(DataType = "string", ElementName = "parameterIdentifier", IsNullable = true)]
    public string ParameterIdentifier { get; set; }
  }
}
