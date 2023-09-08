
// Type: KelioSDK.Models.LaborContractAssignment




using System;
using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "LaborContractAssignment")]
  public class LaborContractAssignment : EmployeeInformation
  {
    [XmlElement(DataType = "boolean", ElementName = "probation", IsNullable = true)]
    public bool? Probation { get; set; }

    [XmlElement(DataType = "string", ElementName = "replacedPersonName", IsNullable = true)]
    public string ReplacedPersonName { get; set; }

    [XmlElement(DataType = "string", ElementName = "replacedPersonIdentificationNumber", IsNullable = true)]
    public string ReplacedPersonIdentificationNumber { get; set; }

    [XmlElement(DataType = "string", ElementName = "attachmentAgencyDescription", IsNullable = true)]
    public string AttachmentAgencyDescription { get; set; }

    [XmlElement(DataType = "string", ElementName = "contractCharacteristicAbbreviation", IsNullable = true)]
    public string ContractCharacteristicAbbreviation { get; set; }

    [XmlElement(DataType = "string", ElementName = "contractCharacteristicDescription", IsNullable = true)]
    public string ContractCharacteristicDescription { get; set; }

    [XmlElement(DataType = "string", ElementName = "attachmentAgencyAbbreviation", IsNullable = true)]
    public string AttachmentAgencyAbbreviation { get; set; }

    [XmlElement(DataType = "string", ElementName = "replacedPersonIdentificationCode", IsNullable = true)]
    public string ReplacedPersonIdentificationCode { get; set; }

    [XmlElement(DataType = "string", ElementName = "ReasonForLeavingComment", IsNullable = true)]
    public string ReasonForLeavingComment { get; set; }

    [XmlElement(DataType = "string", ElementName = "comment", IsNullable = true)]
    public string Comment { get; set; }

    [XmlElement(DataType = "date", ElementName = "payrollTransmissionDay", IsNullable = true)]
    public DateTime? PayrollTransmissionDay { get; set; }

    [XmlElement(DataType = "double", ElementName = "hourlyRate", IsNullable = true)]
    public double? HourlyRate { get; set; }

    [XmlElement(DataType = "date", ElementName = "startDate", IsNullable = true)]
    public DateTime? StartDate { get; set; }

    [XmlElement(DataType = "date", ElementName = "endDate", IsNullable = true)]
    public DateTime? EndDate { get; set; }

    [XmlElement(DataType = "double", ElementName = "wageBand", IsNullable = true)]
    public double? WageBand { get; set; }

    [XmlElement(DataType = "double", ElementName = "invoicedRate", IsNullable = true)]
    public double? InvoicedRate { get; set; }

    [XmlElement(DataType = "string", ElementName = "businessLeaveType", IsNullable = true)]
    public string BusinessLeaveType { get; set; }

    [XmlElement(DataType = "int", ElementName = "numberOfExtension", IsNullable = true)]
    public int? NumberOfExtension { get; set; }

    [XmlElement(DataType = "double", ElementName = "numberOfWeeklyHours", IsNullable = true)]
    public double? NumberOfWeeklyHours { get; set; }

    [XmlElement(DataType = "int", ElementName = "probationStatus", IsNullable = true)]
    public int? ProbationStatus { get; set; }

    [XmlElement(DataType = "date", ElementName = "initialEnd", IsNullable = true)]
    public DateTime? InitialEnd { get; set; }

    [XmlElement(DataType = "string", ElementName = "laborContractNumber", IsNullable = true)]
    public string LaborContractNumber { get; set; }

    [XmlElement(DataType = "int", ElementName = "contractType", IsNullable = true)]
    public int? ContractType { get; set; }

    [XmlElement(DataType = "int", ElementName = "probationDurationUnit", IsNullable = true)]
    public int? ProbationDurationUnit { get; set; }

    [XmlElement(DataType = "int", ElementName = "replacedPersonKey", IsNullable = true)]
    public int? ReplacedPersonKey { get; set; }

    [XmlElement(DataType = "string", ElementName = "useReasonAbbreviation", IsNullable = true)]
    public string UseReasonAbbreviation { get; set; }

    [XmlElement(DataType = "string", ElementName = "ReasonForLeavingCode", IsNullable = true)]
    public string ReasonForLeavingCode { get; set; }

    [XmlElement(DataType = "string", ElementName = "ReasonForLeavingDescription", IsNullable = true)]
    public string ReasonForLeavingDescription { get; set; }

    [XmlElement(DataType = "string", ElementName = "useReasonDescription", IsNullable = true)]
    public string UseReasonDescription { get; set; }

    [XmlElement(DataType = "string", ElementName = "replacedPersonBadgeCode", IsNullable = true)]
    public string ReplacedPersonBadgeCode { get; set; }

    [XmlElement(DataType = "date", ElementName = "probationEndDate", IsNullable = true)]
    public DateTime? ProbationEndDate { get; set; }

    [XmlElement(DataType = "string", ElementName = "laborContractDescription", IsNullable = true)]
    public string LaborContractDescription { get; set; }

    [XmlElement(DataType = "string", ElementName = "laborContractAbbreviation", IsNullable = true)]
    public string LaborContractAbbreviation { get; set; }

    [XmlElement(DataType = "int", ElementName = "laborContractKey", IsNullable = true)]
    public int? LaborContractKey { get; set; }

    [XmlElement(DataType = "string", ElementName = "attachmentDescription", IsNullable = true)]
    public string AttachmentDescription { get; set; }

    [XmlElement(DataType = "int", ElementName = "probationDuration", IsNullable = true)]
    public int? ProbationDuration { get; set; }

    [XmlElement(DataType = "string", ElementName = "replacedPersonSurname", IsNullable = true)]
    public string ReplacedPersonSurname { get; set; }

    [XmlElement(DataType = "string", ElementName = "jobHeldDescription", IsNullable = true)]
    public string JobHeldDescription { get; set; }

    [XmlElement(DataType = "string", ElementName = "jobHeldAbbreviation", IsNullable = true)]
    public string JobHeldAbbreviation { get; set; }

    [XmlElement(DataType = "int", ElementName = "userProfileAssignmentWizardKey", IsNullable = true)]
    public int? UserProfileAssignmentWizardKey { get; set; }

    [XmlElement(DataType = "string", ElementName = "userProfileAssignmentWizardDescription", IsNullable = true)]
    public string UserProfileAssignmentWizardDescription { get; set; }

    [XmlElement(DataType = "date", ElementName = "probationRenewalDate", IsNullable = true)]
    public DateTime? ProbationRenewalDate { get; set; }
  }
}
