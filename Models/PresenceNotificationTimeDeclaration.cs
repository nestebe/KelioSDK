
// Type: KelioSDK.Models.PresenceNotificationTimeDeclaration




using System;
using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "PresenceNotificationTimeDeclaration")]
  public class PresenceNotificationTimeDeclaration : EmployeeInformation
  {
    [XmlElement(DataType = "date", ElementName = "date", IsNullable = true)]
    public DateTime? Date { get; set; }

    [XmlElement(DataType = "string", ElementName = "comment", IsNullable = true)]
    public string Comment { get; set; }

    [XmlElement(DataType = "double", ElementName = "PresenceTimeDeclaration", IsNullable = true)]
    public double? PresenceTimeDeclaration { get; set; }

    [XmlElement(DataType = "string", ElementName = "validatorSurname", IsNullable = true)]
    public string ValidatorSurname { get; set; }

    [XmlElement(DataType = "string", ElementName = "validatorLogin", IsNullable = true)]
    public string ValidatorLogin { get; set; }

    [XmlElement(DataType = "int", ElementName = "validatorKey", IsNullable = true)]
    public int? ValidatorKey { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "RestTimeRespected", IsNullable = true)]
    public bool? RestTimeRespected { get; set; }

    [XmlElement(DataType = "string", ElementName = "validatorIdentificationNumber", IsNullable = true)]
    public string ValidatorIdentificationNumber { get; set; }

    [XmlElement(DataType = "string", ElementName = "validatorFirstName", IsNullable = true)]
    public string ValidatorFirstName { get; set; }

    [XmlElement(DataType = "string", ElementName = "validatorBadgeCode", IsNullable = true)]
    public string ValidatorBadgeCode { get; set; }

    [XmlElement(DataType = "short", ElementName = "declarationState", IsNullable = true)]
    public short? DeclarationState { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "morningPresenceNotificationDeclaration", IsNullable = true)]
    public bool? MorningPresenceNotificationDeclaration { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "afternoonPresenceNotificationDeclaration", IsNullable = true)]
    public bool? AfternoonPresenceNotificationDeclaration { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "PresenceNotificationDeclaration", IsNullable = true)]
    public bool? PresenceNotificationDeclaration { get; set; }

    [XmlElement(DataType = "int", ElementName = "PresenceNotificationDeclarationKey", IsNullable = true)]
    public int? PresenceNotificationDeclarationKey { get; set; }
  }
}
