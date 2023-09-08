
// Type: KelioSDK.Models.EmployeeProfessionalData




using System;
using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "EmployeeProfessionalData")]
  public class EmployeeProfessionalData : EmployeeInformationAndCriterion
  {
    [XmlElement(DataType = "boolean", ElementName = "trialPeriod", IsNullable = true)]
    public bool? TrialPeriod { get; set; }

    [XmlElement(DataType = "string", ElementName = "replacedPersonName", IsNullable = true)]
    public string ReplacedPersonName { get; set; }

    [XmlElement(DataType = "string", ElementName = "replacedPersonIdentificationNumber", IsNullable = true)]
    public string ReplacedPersonIdentificationNumber { get; set; }

    [XmlElement(DataType = "double", ElementName = "currentTimeContractValue", IsNullable = true)]
    public double? CurrentTimeContractValue { get; set; }

    [XmlElement(DataType = "string", ElementName = "currentContractRateDescription", IsNullable = true)]
    public string CurrentContractRateDescription { get; set; }

    [XmlElement(DataType = "string", ElementName = "currentContractRateCode", IsNullable = true)]
    public string CurrentContractRateCode { get; set; }

    [XmlElement(DataType = "date", ElementName = "currentTimeContractRepealDate", IsNullable = true)]
    public DateTime? CurrentTimeContractRepealDate { get; set; }

    [XmlElement(DataType = "int", ElementName = "currentTimeContractTypeCode", IsNullable = true)]
    public int? CurrentTimeContractTypeCode { get; set; }

    [XmlElement(DataType = "string", ElementName = "currentQualificationCode", IsNullable = true)]
    public string CurrentQualificationCode { get; set; }

    [XmlElement(DataType = "string", ElementName = "currentQualificationDescription", IsNullable = true)]
    public string CurrentQualificationDescription { get; set; }

    [XmlElement(DataType = "string", ElementName = "currentCoefficientCode", IsNullable = true)]
    public string CurrentCoefficientCode { get; set; }

    [XmlElement(DataType = "int", ElementName = "currentPersonnelCategoryCode", IsNullable = true)]
    public int? CurrentPersonnelCategoryCode { get; set; }

    [XmlElement(DataType = "date", ElementName = "initialEnd", IsNullable = true)]
    public DateTime? InitialEnd { get; set; }

    [XmlElement(DataType = "string", ElementName = "currentJobPositionCode", IsNullable = true)]
    public string CurrentJobPositionCode { get; set; }

    [XmlElement(DataType = "date", ElementName = "currentPersonnelCategoryDate", IsNullable = true)]
    public DateTime? CurrentPersonnelCategoryDate { get; set; }

    [XmlElement(DataType = "double", ElementName = "hourlyRate", IsNullable = true)]
    public double? HourlyRate { get; set; }

    [XmlElement(DataType = "double", ElementName = "wageBand", IsNullable = true)]
    public double? WageBand { get; set; }

    [XmlElement(DataType = "double", ElementName = "invoicedRate", IsNullable = true)]
    public double? InvoicedRate { get; set; }

    [XmlElement(DataType = "string", ElementName = "takenIntoAccountPeriodReasonForLeavingComment", IsNullable = true)]
    public string TakenIntoAccountPeriodReasonForLeavingComment { get; set; }

    [XmlElement(DataType = "string", ElementName = "takenIntoAccountPeriodReasonForLeavingDescription", IsNullable = true)]
    public string TakenIntoAccountPeriodReasonForLeavingDescription { get; set; }

    [XmlElement(DataType = "string", ElementName = "hourlyBasisDistributionAbbreviation", IsNullable = true)]
    public string HourlyBasisDistributionAbbreviation { get; set; }

    [XmlElement(DataType = "string", ElementName = "hourlyBasisDistributionDescription", IsNullable = true)]
    public string HourlyBasisDistributionDescription { get; set; }

    [XmlElement(DataType = "base64Binary", ElementName = "photo", IsNullable = true)]
    public byte[] Photo { get; set; }

    [XmlElement(DataType = "string", ElementName = "currentPersonnelCategory", IsNullable = true)]
    public string CurrentPersonnelCategory { get; set; }

    [XmlElement(DataType = "int", ElementName = "numberOfExtension", IsNullable = true)]
    public int? NumberOfExtension { get; set; }

    [XmlElement(DataType = "double", ElementName = "numberOfWeeklyHours", IsNullable = true)]
    public double? NumberOfWeeklyHours { get; set; }

    [XmlElement(DataType = "string", ElementName = "currentTimeContractTypeDescription", IsNullable = true)]
    public string CurrentTimeContractTypeDescription { get; set; }

    [XmlElement(DataType = "string", ElementName = "currentProfessionalStatusDescription", IsNullable = true)]
    public string CurrentProfessionalStatusDescription { get; set; }

    [XmlElement(DataType = "string", ElementName = "currentProfessionalStatusCode", IsNullable = true)]
    public string CurrentProfessionalStatusCode { get; set; }

    [XmlElement(DataType = "string", ElementName = "currentJobPositionDescription", IsNullable = true)]
    public string CurrentJobPositionDescription { get; set; }

    [XmlElement(DataType = "string", ElementName = "takenIntoAccountPeriodReasonForLeavingCode", IsNullable = true)]
    public string TakenIntoAccountPeriodReasonForLeavingCode { get; set; }

    [XmlElement(DataType = "date", ElementName = "staffRepresentativeAssignmentStartDate", IsNullable = true)]
    public DateTime? StaffRepresentativeAssignmentStartDate { get; set; }

    [XmlElement(DataType = "string", ElementName = "staffRepresentativeAssignmentDescription", IsNullable = true)]
    public string StaffRepresentativeAssignmentDescription { get; set; }

    [XmlElement(DataType = "string", ElementName = "replacedPersonIdentificationCode", IsNullable = true)]
    public string ReplacedPersonIdentificationCode { get; set; }

    [XmlElement(DataType = "date", ElementName = "staffRepresentativeAssignmentEndDate", IsNullable = true)]
    public DateTime? StaffRepresentativeAssignmentEndDate { get; set; }

    [XmlElement(DataType = "string", ElementName = "businessLeaveType", IsNullable = true)]
    public string BusinessLeaveType { get; set; }

    [XmlElement(DataType = "date", ElementName = "seniorityStartDate", IsNullable = true)]
    public DateTime? SeniorityStartDate { get; set; }

    [XmlElement(DataType = "string", ElementName = "employeeSecondName", IsNullable = true)]
    public string EmployeeSecondName { get; set; }

    [XmlElement(DataType = "string", ElementName = "professionalPhoneNumber1", IsNullable = true)]
    public string ProfessionalPhoneNumber1 { get; set; }

    [XmlElement(DataType = "int", ElementName = "attendanceIndicationMode", IsNullable = true)]
    public int? AttendanceIndicationMode { get; set; }

    [XmlElement(DataType = "string", ElementName = "hourlyContractAssignmentInformation", IsNullable = true)]
    public string HourlyContractAssignmentInformation { get; set; }

    [XmlElement(DataType = "string", ElementName = "professionalEmail", IsNullable = true)]
    public string ProfessionalEmail { get; set; }

    [XmlElement(DataType = "date", ElementName = "currentJobApplicationDate", IsNullable = true)]
    public DateTime? CurrentJobApplicationDate { get; set; }

    [XmlElement(DataType = "date", ElementName = "currentSectionAssigningDate", IsNullable = true)]
    public DateTime? CurrentSectionAssigningDate { get; set; }

    [XmlElement(DataType = "string", ElementName = "currentDepartmentDescription", IsNullable = true)]
    public string CurrentDepartmentDescription { get; set; }

    [XmlElement(DataType = "string", ElementName = "currentSectionFullDescription", IsNullable = true)]
    public string CurrentSectionFullDescription { get; set; }

    [XmlElement(DataType = "string", ElementName = "currentSubDepartmentDescription", IsNullable = true)]
    public string CurrentSubDepartmentDescription { get; set; }

    [XmlElement(DataType = "string", ElementName = "currentHourlyContractAbbreviation", IsNullable = true)]
    public string CurrentHourlyContractAbbreviation { get; set; }

    [XmlElement(DataType = "string", ElementName = "currentTimeContractDescription", IsNullable = true)]
    public string CurrentTimeContractDescription { get; set; }

    [XmlElement(DataType = "string", ElementName = "currentHourlyContractDescription", IsNullable = true)]
    public string CurrentHourlyContractDescription { get; set; }

    [XmlElement(DataType = "string", ElementName = "currentCoefficientDescription", IsNullable = true)]
    public string CurrentCoefficientDescription { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "closePreviousSectionAssignments", IsNullable = true)]
    public bool? ClosePreviousSectionAssignments { get; set; }

    [XmlElement(DataType = "date", ElementName = "presenceManagementDate", IsNullable = true)]
    public DateTime? PresenceManagementDate { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "DefaultRespectedRest", IsNullable = true)]
    public bool? DefaultRespectedRest { get; set; }

    [XmlElement(DataType = "string", ElementName = "currentTimeContractCode", IsNullable = true)]
    public string CurrentTimeContractCode { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "dailyRestTimeDeclaration", IsNullable = true)]
    public bool? DailyRestTimeDeclaration { get; set; }

    [XmlElement(DataType = "int", ElementName = "defaultWorkingTime", IsNullable = true)]
    public int? DefaultWorkingTime { get; set; }

    [XmlElement(DataType = "string", ElementName = "professionalPhoneNumberAbbreviation2", IsNullable = true)]
    public string ProfessionalPhoneNumberAbbreviation2 { get; set; }

    [XmlElement(DataType = "string", ElementName = "professionalPhoneNumberAbbreviation4", IsNullable = true)]
    public string ProfessionalPhoneNumberAbbreviation4 { get; set; }

    [XmlElement(DataType = "string", ElementName = "currentSectionDescription", IsNullable = true)]
    public string CurrentSectionDescription { get; set; }

    [XmlElement(DataType = "date", ElementName = "arrivalInCompanyDate", IsNullable = true)]
    public DateTime? ArrivalInCompanyDate { get; set; }

    [XmlElement(DataType = "int", ElementName = "presenceManagement", IsNullable = true)]
    public int? PresenceManagement { get; set; }

    [XmlElement(DataType = "string", ElementName = "jobHeldDescription", IsNullable = true)]
    public string JobHeldDescription { get; set; }

    [XmlElement(DataType = "string", ElementName = "jobHeldAbbreviation", IsNullable = true)]
    public string JobHeldAbbreviation { get; set; }

    [XmlElement(DataType = "string", ElementName = "staffRepresentativeAssignmentCode", IsNullable = true)]
    public string StaffRepresentativeAssignmentCode { get; set; }

    [XmlElement(DataType = "string", ElementName = "replacedPersonBadgeCode", IsNullable = true)]
    public string ReplacedPersonBadgeCode { get; set; }

    [XmlElement(DataType = "date", ElementName = "trialPeriodEndDate", IsNullable = true)]
    public DateTime? TrialPeriodEndDate { get; set; }

    [XmlElement(DataType = "string", ElementName = "employeeMaidenName", IsNullable = true)]
    public string EmployeeMaidenName { get; set; }

    [XmlElement(DataType = "string", ElementName = "professionalPhoneNumber2", IsNullable = true)]
    public string ProfessionalPhoneNumber2 { get; set; }

    [XmlElement(DataType = "date", ElementName = "reasonForLeavingDate", IsNullable = true)]
    public DateTime? ReasonForLeavingDate { get; set; }

    [XmlElement(DataType = "string", ElementName = "currentJobAbbreviation", IsNullable = true)]
    public string CurrentJobAbbreviation { get; set; }

    [XmlElement(DataType = "string", ElementName = "contractComment", IsNullable = true)]
    public string ContractComment { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "automaticGenerationWorkingTime", IsNullable = true)]
    public bool? AutomaticGenerationWorkingTime { get; set; }

    [XmlElement(DataType = "int", ElementName = "contractType", IsNullable = true)]
    public int? ContractType { get; set; }

    [XmlElement(DataType = "string", ElementName = "attachmentAgencyDescription", IsNullable = true)]
    public string AttachmentAgencyDescription { get; set; }

    [XmlElement(DataType = "string", ElementName = "attachmentAgencyAbbreviation", IsNullable = true)]
    public string AttachmentAgencyAbbreviation { get; set; }

    [XmlElement(DataType = "int", ElementName = "replacedPersonKey", IsNullable = true)]
    public int? ReplacedPersonKey { get; set; }

    [XmlElement(DataType = "date", ElementName = "payrollTransmissionDay", IsNullable = true)]
    public DateTime? PayrollTransmissionDay { get; set; }

    [XmlElement(DataType = "int", ElementName = "trialPeriodDuration", IsNullable = true)]
    public int? TrialPeriodDuration { get; set; }

    [XmlElement(DataType = "string", ElementName = "useReasonDescription", IsNullable = true)]
    public string UseReasonDescription { get; set; }

    [XmlElement(DataType = "string", ElementName = "replacedPersonSurname", IsNullable = true)]
    public string ReplacedPersonSurname { get; set; }

    [XmlElement(DataType = "string", ElementName = "useReasonAbbreviation", IsNullable = true)]
    public string UseReasonAbbreviation { get; set; }

    [XmlElement(DataType = "string", ElementName = "currentTimeContractNumber", IsNullable = true)]
    public string CurrentTimeContractNumber { get; set; }

    [XmlElement(DataType = "string", ElementName = "currentSectionAbbreviation", IsNullable = true)]
    public string CurrentSectionAbbreviation { get; set; }

    [XmlElement(DataType = "string", ElementName = "currentLevel7Description", IsNullable = true)]
    public string CurrentLevel7Description { get; set; }

    [XmlElement(DataType = "string", ElementName = "currentJobDescription", IsNullable = true)]
    public string CurrentJobDescription { get; set; }

    [XmlElement(DataType = "string", ElementName = "currentLevel6Description", IsNullable = true)]
    public string CurrentLevel6Description { get; set; }

    [XmlElement(DataType = "string", ElementName = "currentLevel4Description", IsNullable = true)]
    public string CurrentLevel4Description { get; set; }

    [XmlElement(DataType = "string", ElementName = "currentLevel8Description", IsNullable = true)]
    public string CurrentLevel8Description { get; set; }

    [XmlElement(DataType = "string", ElementName = "currentFirmDescription", IsNullable = true)]
    public string CurrentFirmDescription { get; set; }

    [XmlElement(DataType = "int", ElementName = "currentSectionKey", IsNullable = true)]
    public int? CurrentSectionKey { get; set; }

    [XmlElement(DataType = "string", ElementName = "currentLevel5Description", IsNullable = true)]
    public string CurrentLevel5Description { get; set; }

    [XmlElement(DataType = "string", ElementName = "professionalPhoneNumber4", IsNullable = true)]
    public string ProfessionalPhoneNumber4 { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "isManagedInActivity", IsNullable = true)]
    public bool? IsManagedInActivity { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "automaticPresenceNotification", IsNullable = true)]
    public bool? AutomaticPresenceNotification { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "departureNotification", IsNullable = true)]
    public bool? DepartureNotification { get; set; }

    [XmlElement(DataType = "double", ElementName = "displayedNumberOfHours", IsNullable = true)]
    public double? DisplayedNumberOfHours { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "takenIntoAccountPeriodResetResult", IsNullable = true)]
    public bool? TakenIntoAccountPeriodResetResult { get; set; }

    [XmlElement(DataType = "string", ElementName = "employeeAbbreviation", IsNullable = true)]
    public string EmployeeAbbreviation { get; set; }

    [XmlElement(DataType = "string", ElementName = "professionalPhoneNumber3", IsNullable = true)]
    public string ProfessionalPhoneNumber3 { get; set; }

    [XmlElement(DataType = "string", ElementName = "professionalPhoneNumberAbbreviation1", IsNullable = true)]
    public string ProfessionalPhoneNumberAbbreviation1 { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "isHRWorkspaceEmployee", IsNullable = true)]
    public bool? IsHRWorkspaceEmployee { get; set; }

    [XmlElement(DataType = "string", ElementName = "professionalPhoneNumberAbbreviation3", IsNullable = true)]
    public string ProfessionalPhoneNumberAbbreviation3 { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "toBeScheduled", IsNullable = true)]
    public bool? ToBeScheduled { get; set; }

    [XmlElement(DataType = "int", ElementName = "userProfileAssignmentWizardKey", IsNullable = true)]
    public int? UserProfileAssignmentWizardKey { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "closeExceptionalAssignments", IsNullable = true)]
    public bool? CloseExceptionalAssignments { get; set; }

    [XmlElement(DataType = "string", ElementName = "currentContractCharacteristicDescription", IsNullable = true)]
    public string CurrentContractCharacteristicDescription { get; set; }

    [XmlElement(DataType = "date", ElementName = "currentTimeContractApplicationDate", IsNullable = true)]
    public DateTime? CurrentTimeContractApplicationDate { get; set; }

    [XmlElement(DataType = "string", ElementName = "currentContractCharacteristicCode", IsNullable = true)]
    public string CurrentContractCharacteristicCode { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "closePreviousTakenIntoAccountPeriod", IsNullable = true)]
    public bool? ClosePreviousTakenIntoAccountPeriod { get; set; }

    [XmlElement(DataType = "date", ElementName = "currentWorkingDurationApplicationDate", IsNullable = true)]
    public DateTime? CurrentWorkingDurationApplicationDate { get; set; }

    [XmlElement(DataType = "date", ElementName = "currentCoefficientApplicationDate", IsNullable = true)]
    public DateTime? CurrentCoefficientApplicationDate { get; set; }

    [XmlElement(DataType = "string", ElementName = "userProfileAssignmentWizardDescription", IsNullable = true)]
    public string UserProfileAssignmentWizardDescription { get; set; }
  }
}
