
// Type: KelioSDK.Models.EmployeeDocument




using System;
using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "EmployeeDocument")]
  public class EmployeeDocument : EmployeeInformation
  {
    [XmlElement(DataType = "boolean", ElementName = "privateDocument", IsNullable = true)]
    public bool? PrivateDocument { get; set; }

    [XmlElement(DataType = "string", ElementName = "documentPath", IsNullable = true)]
    public string DocumentPath { get; set; }

    [XmlElement(DataType = "short", ElementName = "documentLocation", IsNullable = true)]
    public short? DocumentLocation { get; set; }

    [XmlElement(DataType = "string", ElementName = "documentDescription", IsNullable = true)]
    public string DocumentDescription { get; set; }

    [XmlElement(DataType = "string", ElementName = "documentComment", IsNullable = true)]
    public string DocumentComment { get; set; }

    [XmlElement(DataType = "base64Binary", ElementName = "documentData", IsNullable = true)]
    public byte[] DocumentData { get; set; }

    [XmlElement(DataType = "string", ElementName = "documentUserLogin", IsNullable = true)]
    public string DocumentUserLogin { get; set; }

    [XmlElement(DataType = "string", ElementName = "trainingTitle", IsNullable = true)]
    public string TrainingTitle { get; set; }

    [XmlElement(DataType = "date", ElementName = "trainingStartDate", IsNullable = true)]
    public DateTime? TrainingStartDate { get; set; }

    [XmlElement(DataType = "int", ElementName = "trainingKey", IsNullable = true)]
    public int? TrainingKey { get; set; }

    [XmlElement(DataType = "string", ElementName = "documentTitle", IsNullable = true)]
    public string DocumentTitle { get; set; }

    [XmlElement(DataType = "string", ElementName = "documentCode", IsNullable = true)]
    public string DocumentCode { get; set; }

    [XmlElement(DataType = "date", ElementName = "documentDate", IsNullable = true)]
    public DateTime? DocumentDate { get; set; }
  }
}
