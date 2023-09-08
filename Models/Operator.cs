
// Type: KelioSDK.Models.Operator




using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "Operator")]
  public class Operator : EmployeeInformation
  {
    [XmlElement(DataType = "string", ElementName = "login", IsNullable = true)]
    public string Login { get; set; }

    [XmlElement(DataType = "string", ElementName = "password", IsNullable = true)]
    public string Password { get; set; }

    [XmlElement(DataType = "string", ElementName = "sendersEmail", IsNullable = true)]
    public string SendersEmail { get; set; }

    [XmlElement(DataType = "string", ElementName = "recipientsEmail", IsNullable = true)]
    public string RecipientsEmail { get; set; }

    [XmlElement(DataType = "int", ElementName = "language", IsNullable = true)]
    public int? Language { get; set; }

    [XmlElement(DataType = "string", ElementName = "operatorFirstName", IsNullable = true)]
    public string OperatorFirstName { get; set; }

    [XmlElement(DataType = "string", ElementName = "worksiteDescription", IsNullable = true)]
    public string WorksiteDescription { get; set; }

    [XmlElement(DataType = "string", ElementName = "operatorSurname", IsNullable = true)]
    public string OperatorSurname { get; set; }

    [XmlElement(DataType = "int", ElementName = "operatorKey", IsNullable = true)]
    public int? OperatorKey { get; set; }

    [XmlElement(DataType = "int", ElementName = "durationVisualization", IsNullable = true)]
    public int? DurationVisualization { get; set; }

    [XmlElement(DataType = "int", ElementName = "siteKey", IsNullable = true)]
    public int? SiteKey { get; set; }
  }
}
