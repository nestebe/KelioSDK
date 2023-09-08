
// Type: KelioSDK.Models.CalculatingFunction




using System;
using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "CalculatingFunction")]
  public class CalculatingFunction : EmployeeInformation
  {
    [XmlElement(DataType = "string", ElementName = "functionDescription", IsNullable = true)]
    public string FunctionDescription { get; set; }

    [XmlElement(DataType = "string", ElementName = "comment", IsNullable = true)]
    public string Comment { get; set; }

    [XmlElement(DataType = "date", ElementName = "executionDate", IsNullable = true)]
    public DateTime? ExecutionDate { get; set; }

    [XmlElement(DataType = "string", ElementName = "detail", IsNullable = true)]
    public string Detail { get; set; }

    [XmlElement(DataType = "int", ElementName = "functionKey", IsNullable = true)]
    public int? FunctionKey { get; set; }

    [XmlElement(DataType = "short", ElementName = "functionType", IsNullable = true)]
    public short? FunctionType { get; set; }
  }
}
