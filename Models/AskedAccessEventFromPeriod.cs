
// Type: KelioSDK.Models.AskedAccessEventFromPeriod




using System;
using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "AskedAccessEventFromPeriod")]
  public class AskedAccessEventFromPeriod
  {
    [XmlElement(DataType = "string", ElementName = "personSurname", IsNullable = true)]
    public string PersonSurname { get; set; }

    [XmlElement(DataType = "string", ElementName = "personBadgeCode", IsNullable = true)]
    public string PersonBadgeCode { get; set; }

    [XmlElement(DataType = "int", ElementName = "eventType", IsNullable = true)]
    public int? EventType { get; set; }

    [XmlElement(DataType = "date", ElementName = "startDate", IsNullable = true)]
    public DateTime? StartDate { get; set; }

    [XmlElement(DataType = "date", ElementName = "endDate", IsNullable = true)]
    public DateTime? EndDate { get; set; }

    [XmlElement(DataType = "int", ElementName = "employeeKey", IsNullable = true)]
    public int? EmployeeKey { get; set; }

    [XmlElement(DataType = "string", ElementName = "personFirstName", IsNullable = true)]
    public string PersonFirstName { get; set; }

    [XmlElement(DataType = "int", ElementName = "startOffset", IsNullable = true)]
    public int? StartOffset { get; set; }

    [XmlElement(DataType = "int", ElementName = "endOffset", IsNullable = true)]
    public int? EndOffset { get; set; }

    [XmlElement(DataType = "string", ElementName = "employeeIdentificationCode", IsNullable = true)]
    public string EmployeeIdentificationCode { get; set; }

    [XmlElement(DataType = "string", ElementName = "employeeIdentificationNumber", IsNullable = true)]
    public string EmployeeIdentificationNumber { get; set; }

    [XmlElement(DataType = "int", ElementName = "dateMode", IsNullable = true)]
    public int? DateMode { get; set; }
  }
}
