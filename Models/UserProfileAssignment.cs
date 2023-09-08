
// Type: KelioSDK.Models.UserProfileAssignment




using KelioSDK.Common;
using System;
using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "UserProfileAssignment")]
  public class UserProfileAssignment : ObjectBase
  {
    [XmlElement(DataType = "string", ElementName = "absenceValidatorReferent", IsNullable = true)]
    public string AbsenceValidatorReferent { get; set; }

    [XmlElement(DataType = "string", ElementName = "userAccountForMailCalendarSynchronisationServer", IsNullable = true)]
    public string UserAccountForMailCalendarSynchronisationServer { get; set; }

    [XmlElement(DataType = "string", ElementName = "mailCalendarSynchronisationServer", IsNullable = true)]
    public string MailCalendarSynchronisationServer { get; set; }

    [XmlElement(DataType = "string", ElementName = "readerGroupDescription", IsNullable = true)]
    public string ReaderGroupDescription { get; set; }

    [XmlElement(DataType = "string", ElementName = "clockingValidatorReferent", IsNullable = true)]
    public string ClockingValidatorReferent { get; set; }

    [XmlElement(DataType = "string", ElementName = "login", IsNullable = true)]
    public string Login { get; set; }

    [XmlElement(DataType = "string", ElementName = "absenceValidatorReferentSuperior", IsNullable = true)]
    public string AbsenceValidatorReferentSuperior { get; set; }

    [XmlElement(DataType = "date", ElementName = "readerGroupStartDate", IsNullable = true)]
    public DateTime? ReaderGroupStartDate { get; set; }

    [XmlElement(DataType = "int", ElementName = "dateFormat", IsNullable = true)]
    public int? DateFormat { get; set; }

    [XmlElement(DataType = "int", ElementName = "timeFormat", IsNullable = true)]
    public int? TimeFormat { get; set; }

    [XmlElement(DataType = "int", ElementName = "employeeDisplayFormat", IsNullable = true)]
    public int? EmployeeDisplayFormat { get; set; }

    [XmlElement(DataType = "string", ElementName = "password", IsNullable = true)]
    public string Password { get; set; }

    [XmlElement(DataType = "int", ElementName = "durationVisualization", IsNullable = true)]
    public int? DurationVisualization { get; set; }

    [XmlElement(DataType = "string", ElementName = "sendersEmail", IsNullable = true)]
    public string SendersEmail { get; set; }

    [XmlElement(DataType = "string", ElementName = "recipientsEmail", IsNullable = true)]
    public string RecipientsEmail { get; set; }

    [XmlElement(DataType = "string", ElementName = "identificationNumber", IsNullable = true)]
    public string IdentificationNumber { get; set; }

    [XmlElement(DataType = "int", ElementName = "language", IsNullable = true)]
    public int? Language { get; set; }

    [XmlElement(DataType = "string", ElementName = "userDictionary", IsNullable = true)]
    public string UserDictionary { get; set; }

    [XmlElement(DataType = "int", ElementName = "attendanceIndicationMode", IsNullable = true)]
    public int? AttendanceIndicationMode { get; set; }

    [XmlElement(DataType = "string", ElementName = "userSurname", IsNullable = true)]
    public string UserSurname { get; set; }

    [XmlElement(DataType = "date", ElementName = "presenceManagementDate", IsNullable = true)]
    public DateTime? PresenceManagementDate { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "DefaultRespectedRest", IsNullable = true)]
    public bool? DefaultRespectedRest { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "dailyRestTimeDeclaration", IsNullable = true)]
    public bool? DailyRestTimeDeclaration { get; set; }

    [XmlElement(DataType = "int", ElementName = "defaultWorkingTime", IsNullable = true)]
    public int? DefaultWorkingTime { get; set; }

    [XmlElement(DataType = "string", ElementName = "clockingValidator", IsNullable = true)]
    public string ClockingValidator { get; set; }

    [XmlElement(DataType = "string", ElementName = "workingSite", IsNullable = true)]
    public string WorkingSite { get; set; }

    [XmlElement(DataType = "string", ElementName = "userFirstName", IsNullable = true)]
    public string UserFirstName { get; set; }

    [XmlElement(DataType = "string", ElementName = "absenceValidator", IsNullable = true)]
    public string AbsenceValidator { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "employeeActiveInPlanning", IsNullable = true)]
    public bool? EmployeeActiveInPlanning { get; set; }

    [XmlElement(DataType = "int", ElementName = "presenceManagement", IsNullable = true)]
    public int? PresenceManagement { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "automaticGenerationWorkingTime", IsNullable = true)]
    public bool? AutomaticGenerationWorkingTime { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "isManagedInActivity", IsNullable = true)]
    public bool? IsManagedInActivity { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "automaticPresenceNotification", IsNullable = true)]
    public bool? AutomaticPresenceNotification { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "departureNotification", IsNullable = true)]
    public bool? DepartureNotification { get; set; }

    [XmlElement(DataType = "double", ElementName = "displayedNumberOfHours", IsNullable = true)]
    public double? DisplayedNumberOfHours { get; set; }

    [XmlElement(DataType = "string", ElementName = "clockingValidatorReferentSuperior", IsNullable = true)]
    public string ClockingValidatorReferentSuperior { get; set; }

    [XmlElement(DataType = "int", ElementName = "profileType", IsNullable = true)]
    public int? ProfileType { get; set; }

    [XmlElement(DataType = "string", ElementName = "profileDescription", IsNullable = true)]
    public string ProfileDescription { get; set; }

    [XmlElement(DataType = "string", ElementName = "populationDescription", IsNullable = true)]
    public string PopulationDescription { get; set; }

    [XmlElement(DataType = "string", ElementName = "badge2Code", IsNullable = true)]
    public string Badge2Code { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "biometricsUser", IsNullable = true)]
    public bool? BiometricsUser { get; set; }

    [XmlElement(DataType = "string", ElementName = "badge1Code", IsNullable = true)]
    public string Badge1Code { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "isHRWorkspaceEmployee", IsNullable = true)]
    public bool? IsHRWorkspaceEmployee { get; set; }

    [XmlElement(DataType = "string", ElementName = "employeeIdentificationCode", IsNullable = true)]
    public string EmployeeIdentificationCode { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "toBeScheduled", IsNullable = true)]
    public bool? ToBeScheduled { get; set; }

    [XmlElement(DataType = "string", ElementName = "employeeSurname", IsNullable = true)]
    public string EmployeeSurname { get; set; }

    [XmlElement(DataType = "string", ElementName = "employeeFirstName", IsNullable = true)]
    public string EmployeeFirstName { get; set; }

    [XmlElement(DataType = "int", ElementName = "populationKey", IsNullable = true)]
    public int? PopulationKey { get; set; }
  }
}
