
// Type: KelioSDK.Models.AskedAccessEvent




using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "askedAccessEvent")]
  public class AskedAccessEvent
  {
    [XmlElement(DataType = "string", ElementName = "personSurname", IsNullable = true)]
    public string PersonSurname { get; set; }

    [XmlElement(DataType = "string", ElementName = "personBadgeCode", IsNullable = true)]
    public string PersonBadgeCode { get; set; }

    [XmlElement(DataType = "string", ElementName = "eventType", IsNullable = true)]
    public string EventType { get; set; }

    [XmlElement(DataType = "int", ElementName = "employeeKey", IsNullable = true)]
    public int? EmployeeKey { get; set; }

    [XmlElement(DataType = "string", ElementName = "personFirstName", IsNullable = true)]
    public string PersonFirstName { get; set; }

    [XmlElement(DataType = "string", ElementName = "employeeIdentificationCode", IsNullable = true)]
    public string EmployeeIdentificationCode { get; set; }

    [XmlElement(DataType = "string", ElementName = "employeeIdentificationNumber", IsNullable = true)]
    public string EmployeeIdentificationNumber { get; set; }
  }
}
