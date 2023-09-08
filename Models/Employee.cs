
// Type: KelioSDK.Models.Employee




using KelioSDK.Common;
using System;
using System.Globalization;
using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "Employee")]
  public class Employee : ObjectBase
  {
    [XmlElement(DataType = "string", ElementName = "region", IsNullable = true)]
    public string Region { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "useDefaultModelEmployee", IsNullable = true)]
    public bool? UseDefaultModelEmployee { get; set; }

    [XmlElement(DataType = "string", ElementName = "defaultEmployeeIdentificationNumber", IsNullable = true)]
    public string DefaultEmployeeIdentificationNumber { get; set; }

    [XmlElement(DataType = "string", ElementName = "defaultEmployeeFirstName", IsNullable = true)]
    public string DefaultEmployeeFirstName { get; set; }

    [XmlElement(DataType = "date", ElementName = "takenIntoAccountPeriodStartDate", IsNullable = true)]
    public DateTime? TakenIntoAccountPeriodStartDate { get; set; }

    [XmlElement(DataType = "string", ElementName = "defaultEmployeeIdentificationCode", IsNullable = true)]
    public string DefaultEmployeeIdentificationCode { get; set; }

    [XmlElement(DataType = "base64Binary", ElementName = "photo", IsNullable = true)]
    public byte[] Photo { get; set; }

    [XmlElement(DataType = "string", ElementName = "surname", IsNullable = true)]
    public string Surname { get; set; }

    [XmlElement(DataType = "string", ElementName = "login", IsNullable = true)]
    public string Login { get; set; }

    [XmlElement(DataType = "string", ElementName = "comment", IsNullable = true)]
    public string Comment { get; set; }

    [XmlElement(DataType = "string", ElementName = "firstName", IsNullable = true)]
    public string FirstName { get; set; }

    [XmlElement(DataType = "string", ElementName = "password", IsNullable = true)]
    public string Password { get; set; }

    [XmlElement(DataType = "int", ElementName = "durationVisualization", IsNullable = true)]
    public int? DurationVisualization { get; set; }

    [XmlElement(DataType = "date", ElementName = "seniorityStartDate", IsNullable = true)]
    public DateTime? SeniorityStartDate { get; set; }

    [XmlElement(DataType = "string", ElementName = "sendersEmail", IsNullable = true)]
    public string SendersEmail { get; set; }

    [XmlElement(DataType = "string", ElementName = "recipientsEmail", IsNullable = true)]
    public string RecipientsEmail { get; set; }

    [XmlElement(DataType = "date", ElementName = "timeSavingEndDate", IsNullable = true)]
    public DateTime? TimeSavingEndDate { get; set; }

    [XmlElement(DataType = "int", ElementName = "sex", IsNullable = true)]
    public int? Sex { get; set; }

    [XmlElement(DataType = "string", ElementName = "postcode", IsNullable = true)]
    public string Postcode { get; set; }

    [XmlElement(DataType = "string", ElementName = "identificationNumber", IsNullable = true)]
    public string IdentificationNumber { get; set; }

    [XmlElement(DataType = "string", ElementName = "attachedDocument", IsNullable = true)]
    public string AttachedDocument { get; set; }

    [XmlElement(DataType = "string", ElementName = "address", IsNullable = true)]
    public string Address { get; set; }

    [XmlElement(DataType = "int", ElementName = "language", IsNullable = true)]
    public int? Language { get; set; }

    [XmlElement(DataType = "string", ElementName = "town", IsNullable = true)]
    public string Town { get; set; }

    [XmlElement(DataType = "string", ElementName = "absenceValidator", IsNullable = true)]
    public string AbsenceValidator { get; set; }

    [XmlElement(DataType = "date", ElementName = "birthDate", IsNullable = true)]
    public DateTime? BirthDate { get; set; }

    [XmlElement(DataType = "date", ElementName = "currentPublicHolidayCalendarApplicationDate", IsNullable = true)]
    public DateTime? CurrentPublicHolidayCalendarApplicationDate { get; set; }

    [XmlElement(DataType = "date", ElementName = "currentClassOfCheckApplicationDate", IsNullable = true)]
    public DateTime? CurrentClassOfCheckApplicationDate { get; set; }

    [XmlElement(DataType = "date", ElementName = "currentEndOfPeriodCalendarApplicationDate", IsNullable = true)]
    public DateTime? CurrentEndOfPeriodCalendarApplicationDate { get; set; }

    [XmlElement(DataType = "string", ElementName = "clockingValidator", IsNullable = true)]
    public string ClockingValidator { get; set; }

    [XmlElement(DataType = "string", ElementName = "personalCode", IsNullable = true)]
    public string PersonalCode { get; set; }

    [XmlElement(DataType = "int", ElementName = "attendanceIndicationMode", IsNullable = true)]
    public int? AttendanceIndicationMode { get; set; }

    [XmlElement(DataType = "string", ElementName = "publicHolServiceCalendar", IsNullable = true)]
    public string PublicHolServiceCalendar { get; set; }

    [XmlElement(DataType = "date", ElementName = "currentScheduleApplicationDate", IsNullable = true)]
    public DateTime? CurrentScheduleApplicationDate { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "flexileaveAbsenceAllowance", IsNullable = true)]
    public bool? FlexileaveAbsenceAllowance { get; set; }

    [XmlElement(DataType = "string", ElementName = "professionalEmail", IsNullable = true)]
    public string ProfessionalEmail { get; set; }

    [XmlElement(DataType = "date", ElementName = "currentJobApplicationDate", IsNullable = true)]
    public DateTime? CurrentJobApplicationDate { get; set; }

    [XmlElement(DataType = "date", ElementName = "currentSectionAssigningDate", IsNullable = true)]
    public DateTime? CurrentSectionAssigningDate { get; set; }

    [XmlElement(DataType = "date", ElementName = "currentAccessProfileAssigningEndDate", IsNullable = true)]
    public DateTime? CurrentAccessProfileAssigningEndDate { get; set; }

    [XmlElement(DataType = "date", ElementName = "accessAuthorizationStartDate", IsNullable = true)]
    public DateTime? AccessAuthorizationStartDate { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "automaticAbsenceAllowance", IsNullable = true)]
    public bool? AutomaticAbsenceAllowance { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "concernedByAntiPassbacks", IsNullable = true)]
    public bool? ConcernedByAntiPassbacks { get; set; }

    [XmlElement(DataType = "date", ElementName = "accessAuthorizationEndDate", IsNullable = true)]
    public DateTime? AccessAuthorizationEndDate { get; set; }

    [XmlIgnore]
    public TimeSpan? AccessAuthorizationEndTime { get; set; }

    [XmlElement(DataType = "string", ElementName = "accessAuthorizationEndTime", IsNullable = true)]
    public string AccessAuthorizationEndTimeField
    {
      get
      {
        return !this.AccessAuthorizationEndTime.HasValue ? (string) null : this.AccessAuthorizationEndTime.Value.ToString("hh\\:mm\\:ss", (IFormatProvider) CultureInfo.InvariantCulture);
      }
      set
      {
        this.AccessAuthorizationEndTime = value == null ? new TimeSpan?() : new TimeSpan?(TimeSpan.ParseExact(value, "hh\\:mm\\:ss", (IFormatProvider) CultureInfo.InvariantCulture));
      }
    }

    [XmlElement(DataType = "string", ElementName = "currentDepartmentDescription", IsNullable = true)]
    public string CurrentDepartmentDescription { get; set; }

    [XmlElement(DataType = "string", ElementName = "currentAccessProfileDescription", IsNullable = true)]
    public string CurrentAccessProfileDescription { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "automaticClockingAllowance", IsNullable = true)]
    public bool? AutomaticClockingAllowance { get; set; }

    [XmlElement(DataType = "string", ElementName = "currentSectionFullDescription", IsNullable = true)]
    public string CurrentSectionFullDescription { get; set; }

    [XmlElement(DataType = "string", ElementName = "currentSubDepartmentDescription", IsNullable = true)]
    public string CurrentSubDepartmentDescription { get; set; }

    [XmlElement(DataType = "string", ElementName = "personalWorkspaceProfileDescription", IsNullable = true)]
    public string PersonalWorkspaceProfileDescription { get; set; }

    [XmlElement(DataType = "string", ElementName = "currentHourlyContractAbbreviation", IsNullable = true)]
    public string CurrentHourlyContractAbbreviation { get; set; }

    [XmlIgnore]
    public TimeSpan? AccessAuthorizationStartTime { get; set; }

    [XmlElement(DataType = "string", ElementName = "accessAuthorizationStartTime", IsNullable = true)]
    public string AccessAuthorizationStartTimeField
    {
      get
      {
        return !this.AccessAuthorizationStartTime.HasValue ? (string) null : this.AccessAuthorizationStartTime.Value.ToString("hh\\:mm\\:ss", (IFormatProvider) CultureInfo.InvariantCulture);
      }
      set
      {
        this.AccessAuthorizationStartTime = value == null ? new TimeSpan?() : new TimeSpan?(TimeSpan.ParseExact(value, "hh\\:mm\\:ss", (IFormatProvider) CultureInfo.InvariantCulture));
      }
    }

    [XmlElement(DataType = "string", ElementName = "currentTimeContractDescription", IsNullable = true)]
    public string CurrentTimeContractDescription { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "automaticClockingOutAllowance", IsNullable = true)]
    public bool? AutomaticClockingOutAllowance { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "compensatoryLeaveAllowance", IsNullable = true)]
    public bool? CompensatoryLeaveAllowance { get; set; }

    [XmlElement(DataType = "string", ElementName = "currentHourlyContractDescription", IsNullable = true)]
    public string CurrentHourlyContractDescription { get; set; }

    [XmlElement(DataType = "string", ElementName = "currentCoefficientDescription", IsNullable = true)]
    public string CurrentCoefficientDescription { get; set; }

    [XmlElement(DataType = "string", ElementName = "defaultCostCentreAbbreviation", IsNullable = true)]
    public string DefaultCostCentreAbbreviation { get; set; }

    [XmlElement(DataType = "int", ElementName = "currentTimeContractType", IsNullable = true)]
    public int? CurrentTimeContractType { get; set; }

    [XmlElement(DataType = "date", ElementName = "defaultActivityEndDate", IsNullable = true)]
    public DateTime? DefaultActivityEndDate { get; set; }

    [XmlElement(DataType = "string", ElementName = "defaultCostCentreCode", IsNullable = true)]
    public string DefaultCostCentreCode { get; set; }

    [XmlElement(DataType = "string", ElementName = "defaultJobDescription", IsNullable = true)]
    public string DefaultJobDescription { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "closePreviousSectionAssignments", IsNullable = true)]
    public bool? ClosePreviousSectionAssignments { get; set; }

    [XmlElement(DataType = "string", ElementName = "visitorSectionDescription", IsNullable = true)]
    public string VisitorSectionDescription { get; set; }

    [XmlElement(DataType = "date", ElementName = "presenceManagementDate", IsNullable = true)]
    public DateTime? PresenceManagementDate { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "DefaultRespectedRest", IsNullable = true)]
    public bool? DefaultRespectedRest { get; set; }

    [XmlElement(DataType = "string", ElementName = "currentTimeContractCode", IsNullable = true)]
    public string CurrentTimeContractCode { get; set; }

    [XmlElement(DataType = "double", ElementName = "currentTimeContractValue", IsNullable = true)]
    public double? CurrentTimeContractValue { get; set; }

    [XmlElement(DataType = "string", ElementName = "professionalPhoneNumber2", IsNullable = true)]
    public string ProfessionalPhoneNumber2 { get; set; }

    [XmlElement(DataType = "string", ElementName = "defaultJobAbbreviation", IsNullable = true)]
    public string DefaultJobAbbreviation { get; set; }

    [XmlElement(DataType = "date", ElementName = "readerGroupStartDate", IsNullable = true)]
    public DateTime? ReaderGroupStartDate { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "dailyRestTimeDeclaration", IsNullable = true)]
    public bool? DailyRestTimeDeclaration { get; set; }

    [XmlElement(DataType = "int", ElementName = "defaultWorkingTime", IsNullable = true)]
    public int? DefaultWorkingTime { get; set; }

    [XmlElement(DataType = "string", ElementName = "currentTimeContractNumber", IsNullable = true)]
    public string CurrentTimeContractNumber { get; set; }

    [XmlElement(DataType = "string", ElementName = "professionalPhoneNumberAbbreviation2", IsNullable = true)]
    public string ProfessionalPhoneNumberAbbreviation2 { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "defaultJobAutomaticGeneration", IsNullable = true)]
    public bool? DefaultJobAutomaticGeneration { get; set; }

    [XmlElement(DataType = "string", ElementName = "professionalPhoneNumber1", IsNullable = true)]
    public string ProfessionalPhoneNumber1 { get; set; }

    [XmlElement(DataType = "string", ElementName = "professionalPhoneNumberAbbreviation4", IsNullable = true)]
    public string ProfessionalPhoneNumberAbbreviation4 { get; set; }

    [XmlElement(DataType = "string", ElementName = "defaultCustomerDescription", IsNullable = true)]
    public string DefaultCustomerDescription { get; set; }

    [XmlElement(DataType = "string", ElementName = "currentSectionDescription", IsNullable = true)]
    public string CurrentSectionDescription { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "isTandAModuleEmployee", IsNullable = true)]
    public bool? IsTandAModuleEmployee { get; set; }

    [XmlElement(DataType = "date", ElementName = "arrivalInCompanyDate", IsNullable = true)]
    public DateTime? ArrivalInCompanyDate { get; set; }

    [XmlElement(DataType = "int", ElementName = "presenceManagement", IsNullable = true)]
    public int? PresenceManagement { get; set; }

    [XmlElement(DataType = "int", ElementName = "visitorUsedBadge", IsNullable = true)]
    public int? VisitorUsedBadge { get; set; }

    [XmlElement(DataType = "string", ElementName = "adressAddition1", IsNullable = true)]
    public string AdressAddition1 { get; set; }

    [XmlElement(DataType = "string", ElementName = "adressAddition2", IsNullable = true)]
    public string AdressAddition2 { get; set; }

    [XmlElement(DataType = "string", ElementName = "privateEmail", IsNullable = true)]
    public string PrivateEmail { get; set; }

    [XmlElement(DataType = "string", ElementName = "currentSectionAbbreviation", IsNullable = true)]
    public string CurrentSectionAbbreviation { get; set; }

    [XmlElement(DataType = "string", ElementName = "currentScheduleAbbreviation", IsNullable = true)]
    public string CurrentScheduleAbbreviation { get; set; }

    [XmlElement(DataType = "string", ElementName = "currentScheduleDescription", IsNullable = true)]
    public string CurrentScheduleDescription { get; set; }

    [XmlElement(DataType = "string", ElementName = "profileDescription", IsNullable = true)]
    public string ProfileDescription { get; set; }

    [XmlElement(DataType = "string", ElementName = "mobileProfileDescription", IsNullable = true)]
    public string MobileProfileDescription { get; set; }

    [XmlElement(DataType = "string", ElementName = "currentLevel7Description", IsNullable = true)]
    public string CurrentLevel7Description { get; set; }

    [XmlElement(DataType = "string", ElementName = "currentJobDescription", IsNullable = true)]
    public string CurrentJobDescription { get; set; }

    [XmlElement(DataType = "string", ElementName = "currentShiftSchedulerDescription", IsNullable = true)]
    public string CurrentShiftSchedulerDescription { get; set; }

    [XmlElement(DataType = "string", ElementName = "currentLevel6Description", IsNullable = true)]
    public string CurrentLevel6Description { get; set; }

    [XmlElement(DataType = "string", ElementName = "currentLevel4Description", IsNullable = true)]
    public string CurrentLevel4Description { get; set; }

    [XmlElement(DataType = "string", ElementName = "currentLevel8Description", IsNullable = true)]
    public string CurrentLevel8Description { get; set; }

    [XmlElement(DataType = "string", ElementName = "currentFirmDescription", IsNullable = true)]
    public string CurrentFirmDescription { get; set; }

    [XmlElement(DataType = "string", ElementName = "userPortalProfileDescription", IsNullable = true)]
    public string UserPortalProfileDescription { get; set; }

    [XmlElement(DataType = "int", ElementName = "currentSectionKey", IsNullable = true)]
    public int? CurrentSectionKey { get; set; }

    [XmlElement(DataType = "string", ElementName = "currentLevel5Description", IsNullable = true)]
    public string CurrentLevel5Description { get; set; }

    [XmlElement(DataType = "string", ElementName = "nationalInsuranceNumber", IsNullable = true)]
    public string NationalInsuranceNumber { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "clockingWithoutBadgeAllowance", IsNullable = true)]
    public bool? ClockingWithoutBadgeAllowance { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "passwordNeverChange", IsNullable = true)]
    public bool? PasswordNeverChange { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "superPassEverywhere", IsNullable = true)]
    public bool? SuperPassEverywhere { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "extendedTimeout", IsNullable = true)]
    public bool? ExtendedTimeout { get; set; }

    [XmlElement(DataType = "string", ElementName = "privatePhoneNumber1", IsNullable = true)]
    public string PrivatePhoneNumber1 { get; set; }

    [XmlElement(DataType = "string", ElementName = "readerGroupDescription", IsNullable = true)]
    public string ReaderGroupDescription { get; set; }

    [XmlElement(DataType = "string", ElementName = "privatePhoneNumber2", IsNullable = true)]
    public string PrivatePhoneNumber2 { get; set; }

    [XmlElement(DataType = "int", ElementName = "publicHolidayPaymentType", IsNullable = true)]
    public int? PublicHolidayPaymentType { get; set; }

    [XmlElement(DataType = "string", ElementName = "defaultJobCode", IsNullable = true)]
    public string DefaultJobCode { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "givesUpSplitting", IsNullable = true)]
    public bool? GivesUpSplitting { get; set; }

    [XmlElement(DataType = "string", ElementName = "professionalPhoneNumber4", IsNullable = true)]
    public string ProfessionalPhoneNumber4 { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "isManagedInActivity", IsNullable = true)]
    public bool? IsManagedInActivity { get; set; }

    [XmlElement(DataType = "string", ElementName = "defaultCustomerCode", IsNullable = true)]
    public string DefaultCustomerCode { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "automaticPresenceNotification", IsNullable = true)]
    public bool? AutomaticPresenceNotification { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "departureNotification", IsNullable = true)]
    public bool? DepartureNotification { get; set; }

    [XmlElement(DataType = "string", ElementName = "defaultCustomerAbbreviation", IsNullable = true)]
    public string DefaultCustomerAbbreviation { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "receiveVisitor", IsNullable = true)]
    public bool? ReceiveVisitor { get; set; }

    [XmlElement(DataType = "double", ElementName = "displayedNumberOfHours", IsNullable = true)]
    public double? DisplayedNumberOfHours { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "visitorOfOtherSiteAllowance", IsNullable = true)]
    public bool? VisitorOfOtherSiteAllowance { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "searchUsingBadge", IsNullable = true)]
    public bool? SearchUsingBadge { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "searchUsingSurname", IsNullable = true)]
    public bool? SearchUsingSurname { get; set; }

    [XmlElement(DataType = "string", ElementName = "defaultEmployeeSurname", IsNullable = true)]
    public string DefaultEmployeeSurname { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "searchUsingIdentificationNumber", IsNullable = true)]
    public bool? SearchUsingIdentificationNumber { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "searchUsingFirstname", IsNullable = true)]
    public bool? SearchUsingFirstname { get; set; }

    [XmlElement(DataType = "string", ElementName = "defaultEmployeeBadge", IsNullable = true)]
    public string DefaultEmployeeBadge { get; set; }

    [XmlElement(DataType = "date", ElementName = "takenIntoAccountPeriodEndDate", IsNullable = true)]
    public DateTime? TakenIntoAccountPeriodEndDate { get; set; }

    [XmlElement(DataType = "string", ElementName = "badge2Code", IsNullable = true)]
    public string Badge2Code { get; set; }

    [XmlElement(DataType = "string", ElementName = "emergencyContact", IsNullable = true)]
    public string EmergencyContact { get; set; }

    [XmlElement(DataType = "string", ElementName = "adressCountryDescription", IsNullable = true)]
    public string AdressCountryDescription { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "takenIntoAccountPeriodResetResult", IsNullable = true)]
    public bool? TakenIntoAccountPeriodResetResult { get; set; }

    [XmlElement(DataType = "string", ElementName = "employeeAbbreviation", IsNullable = true)]
    public string EmployeeAbbreviation { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "authenticate", IsNullable = true)]
    public bool? Authenticate { get; set; }

    [XmlElement(DataType = "string", ElementName = "badge1Code", IsNullable = true)]
    public string Badge1Code { get; set; }

    [XmlElement(DataType = "string", ElementName = "professionalPhoneNumber3", IsNullable = true)]
    public string ProfessionalPhoneNumber3 { get; set; }

    [XmlElement(DataType = "string", ElementName = "professionalPhoneNumberAbbreviation1", IsNullable = true)]
    public string ProfessionalPhoneNumberAbbreviation1 { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "isHRWorkspaceEmployee", IsNullable = true)]
    public bool? IsHRWorkspaceEmployee { get; set; }

    [XmlElement(DataType = "string", ElementName = "employeeIdentificationCode", IsNullable = true)]
    public string EmployeeIdentificationCode { get; set; }

    [XmlElement(DataType = "string", ElementName = "professionalPhoneNumberAbbreviation3", IsNullable = true)]
    public string ProfessionalPhoneNumberAbbreviation3 { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "toBeScheduled", IsNullable = true)]
    public bool? ToBeScheduled { get; set; }

    [XmlElement(DataType = "string", ElementName = "workingSite", IsNullable = true)]
    public string WorkingSite { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "isJobCostingModuleEmployee", IsNullable = true)]
    public bool? IsJobCostingModuleEmployee { get; set; }

    [XmlElement(DataType = "string", ElementName = "privatePhoneNumber3", IsNullable = true)]
    public string PrivatePhoneNumber3 { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "superPass", IsNullable = true)]
    public bool? SuperPass { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "automaticGenerationWorkingTime", IsNullable = true)]
    public bool? AutomaticGenerationWorkingTime { get; set; }

    [XmlElement(DataType = "int", ElementName = "userProfileAssignmentWizardKey", IsNullable = true)]
    public int? UserProfileAssignmentWizardKey { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "closeExceptionalAssignments", IsNullable = true)]
    public bool? CloseExceptionalAssignments { get; set; }

    [XmlElement(DataType = "int", ElementName = "employeeKey", IsNullable = true)]
    public int? EmployeeKey { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "isAccessModuleEmployee", IsNullable = true)]
    public bool? IsAccessModuleEmployee { get; set; }

    [XmlElement(DataType = "date", ElementName = "defaultJobApplicationDate", IsNullable = true)]
    public DateTime? DefaultJobApplicationDate { get; set; }

    [XmlElement(DataType = "string", ElementName = "currentContractCharacteristicDescription", IsNullable = true)]
    public string CurrentContractCharacteristicDescription { get; set; }

    [XmlElement(DataType = "date", ElementName = "currentTimeContractApplicationDate", IsNullable = true)]
    public DateTime? CurrentTimeContractApplicationDate { get; set; }

    [XmlElement(DataType = "string", ElementName = "currentEndOfPeriodCalendarDescription", IsNullable = true)]
    public string CurrentEndOfPeriodCalendarDescription { get; set; }

    [XmlElement(DataType = "string", ElementName = "currentCalculationConfigurationDescription", IsNullable = true)]
    public string CurrentCalculationConfigurationDescription { get; set; }

    [XmlElement(DataType = "date", ElementName = "currentAccessProfileAssigningDate", IsNullable = true)]
    public DateTime? CurrentAccessProfileAssigningDate { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "specificSchedulesAllowance", IsNullable = true)]
    public bool? SpecificSchedulesAllowance { get; set; }

    [XmlElement(DataType = "string", ElementName = "defaultCostCentreDescription", IsNullable = true)]
    public string DefaultCostCentreDescription { get; set; }

    [XmlElement(DataType = "string", ElementName = "currentContractCharacteristicCode", IsNullable = true)]
    public string CurrentContractCharacteristicCode { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "closePreviousTakenIntoAccountPeriod", IsNullable = true)]
    public bool? ClosePreviousTakenIntoAccountPeriod { get; set; }

    [XmlElement(DataType = "string", ElementName = "currentClassOfCheckDescription", IsNullable = true)]
    public string CurrentClassOfCheckDescription { get; set; }

    [XmlElement(DataType = "date", ElementName = "currentWorkingDurationApplicationDate", IsNullable = true)]
    public DateTime? CurrentWorkingDurationApplicationDate { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "centralAlarmSystemManualActivationAllowance", IsNullable = true)]
    public bool? CentralAlarmSystemManualActivationAllowance { get; set; }

    [XmlElement(DataType = "string", ElementName = "currentPublicHolidayCalendarDescription", IsNullable = true)]
    public string CurrentPublicHolidayCalendarDescription { get; set; }

    [XmlElement(DataType = "date", ElementName = "currentClassOfCheckEndDate", IsNullable = true)]
    public DateTime? CurrentClassOfCheckEndDate { get; set; }

    [XmlElement(DataType = "date", ElementName = "currentCoefficientApplicationDate", IsNullable = true)]
    public DateTime? CurrentCoefficientApplicationDate { get; set; }

    [XmlElement(DataType = "date", ElementName = "currentCalculationConfigurationApplicationDate", IsNullable = true)]
    public DateTime? CurrentCalculationConfigurationApplicationDate { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "specificSchedulesEverywhereAllowance", IsNullable = true)]
    public bool? SpecificSchedulesEverywhereAllowance { get; set; }

    [XmlElement(DataType = "string", ElementName = "userProfileAssignmentWizardDescription", IsNullable = true)]
    public string UserProfileAssignmentWizardDescription { get; set; }

    [XmlElement(DataType = "date", ElementName = "authorisedFunctionAssignmentStartDate", IsNullable = true)]
    public DateTime? AuthorisedFunctionAssignmentStartDate { get; set; }
  }
}
