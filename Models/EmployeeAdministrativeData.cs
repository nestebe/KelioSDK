
// Type: KelioSDK.Models.EmployeeAdministrativeData




using System;
using System.Globalization;
using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "EmployeeAdministrativeData")]
  public class EmployeeAdministrativeData : EmployeeInformationAndCriterion
  {
    [XmlElement(DataType = "string", ElementName = "professionalBankAccountHolder", IsNullable = true)]
    public string ProfessionalBankAccountHolder { get; set; }

    [XmlElement(DataType = "string", ElementName = "professionalBankAccountBBANCode", IsNullable = true)]
    public string ProfessionalBankAccountBBANCode { get; set; }

    [XmlElement(DataType = "string", ElementName = "professionalBankAccountIban2", IsNullable = true)]
    public string ProfessionalBankAccountIban2 { get; set; }

    [XmlElement(DataType = "string", ElementName = "professionalBankAccountBICSWIFTCode2", IsNullable = true)]
    public string ProfessionalBankAccountBICSWIFTCode2 { get; set; }

    [XmlElement(DataType = "string", ElementName = "professionalBankAccountHolder2", IsNullable = true)]
    public string ProfessionalBankAccountHolder2 { get; set; }

    [XmlElement(DataType = "string", ElementName = "personnalBankAccountBBANCode", IsNullable = true)]
    public string PersonnalBankAccountBBANCode { get; set; }

    [XmlElement(DataType = "string", ElementName = "professionalBankAccountCountry2", IsNullable = true)]
    public string ProfessionalBankAccountCountry2 { get; set; }

    [XmlElement(DataType = "string", ElementName = "professionalBankAccountBBANCode2", IsNullable = true)]
    public string ProfessionalBankAccountBBANCode2 { get; set; }

    [XmlElement(DataType = "string", ElementName = "professionalBankAccountCountry", IsNullable = true)]
    public string ProfessionalBankAccountCountry { get; set; }

    [XmlElement(DataType = "date", ElementName = "residencePermitIssueDate", IsNullable = true)]
    public DateTime? ResidencePermitIssueDate { get; set; }

    [XmlIgnore]
    public TimeSpan? NextMedicalExaminationTime { get; set; }

    [XmlElement(DataType = "string", ElementName = "nextMedicalExaminationTime", IsNullable = true)]
    public string NextMedicalExaminationTimeField
    {
      get
      {
        return !this.NextMedicalExaminationTime.HasValue ? (string) null : this.NextMedicalExaminationTime.Value.ToString("hh\\:mm\\:ss", (IFormatProvider) CultureInfo.InvariantCulture);
      }
      set
      {
        this.NextMedicalExaminationTime = value == null ? new TimeSpan?() : new TimeSpan?(TimeSpan.ParseExact(value, "hh\\:mm\\:ss", (IFormatProvider) CultureInfo.InvariantCulture));
      }
    }

    [XmlElement(DataType = "string", ElementName = "professionalBankAccountIban", IsNullable = true)]
    public string ProfessionalBankAccountIban { get; set; }

    [XmlElement(DataType = "date", ElementName = "vehicleAssignmentDate", IsNullable = true)]
    public DateTime? VehicleAssignmentDate { get; set; }

    [XmlElement(DataType = "date", ElementName = "previousMedicalExaminationDate", IsNullable = true)]
    public DateTime? PreviousMedicalExaminationDate { get; set; }

    [XmlElement(DataType = "date", ElementName = "residencePermitExpiryDate", IsNullable = true)]
    public DateTime? ResidencePermitExpiryDate { get; set; }

    [XmlIgnore]
    public TimeSpan? PreviousMedicalExaminationTime { get; set; }

    [XmlElement(DataType = "string", ElementName = "previousMedicalExaminationTime", IsNullable = true)]
    public string PreviousMedicalExaminationTimeField
    {
      get
      {
        return !this.PreviousMedicalExaminationTime.HasValue ? (string) null : this.PreviousMedicalExaminationTime.Value.ToString("hh\\:mm\\:ss", (IFormatProvider) CultureInfo.InvariantCulture);
      }
      set
      {
        this.PreviousMedicalExaminationTime = value == null ? new TimeSpan?() : new TimeSpan?(TimeSpan.ParseExact(value, "hh\\:mm\\:ss", (IFormatProvider) CultureInfo.InvariantCulture));
      }
    }

    [XmlElement(DataType = "string", ElementName = "previousMedicalExaminationState", IsNullable = true)]
    public string PreviousMedicalExaminationState { get; set; }

    [XmlElement(DataType = "string", ElementName = "residencePermitIssuedBy", IsNullable = true)]
    public string ResidencePermitIssuedBy { get; set; }

    [XmlElement(DataType = "string", ElementName = "nextMedicalExaminationState", IsNullable = true)]
    public string NextMedicalExaminationState { get; set; }

    [XmlElement(DataType = "string", ElementName = "bankIdentityComment", IsNullable = true)]
    public string BankIdentityComment { get; set; }

    [XmlElement(DataType = "int", ElementName = "personnalBankAccountType", IsNullable = true)]
    public int? PersonnalBankAccountType { get; set; }

    [XmlElement(DataType = "string", ElementName = "privateBankAccountCountry2", IsNullable = true)]
    public string PrivateBankAccountCountry2 { get; set; }

    [XmlElement(DataType = "string", ElementName = "professionalBankAccountBICSWIFTCode", IsNullable = true)]
    public string ProfessionalBankAccountBICSWIFTCode { get; set; }

    [XmlElement(DataType = "int", ElementName = "professionalBankAccountType2", IsNullable = true)]
    public int? ProfessionalBankAccountType2 { get; set; }

    [XmlElement(DataType = "string", ElementName = "privateBankAccountBank", IsNullable = true)]
    public string PrivateBankAccountBank { get; set; }

    [XmlElement(DataType = "int", ElementName = "personnalBankAccountType2", IsNullable = true)]
    public int? PersonnalBankAccountType2 { get; set; }

    [XmlElement(DataType = "string", ElementName = "privateBankAccountCountry", IsNullable = true)]
    public string PrivateBankAccountCountry { get; set; }

    [XmlElement(DataType = "string", ElementName = "privateBankAccountIban", IsNullable = true)]
    public string PrivateBankAccountIban { get; set; }

    [XmlElement(DataType = "string", ElementName = "personnalBankAccountBICSWIFTCode", IsNullable = true)]
    public string PersonnalBankAccountBICSWIFTCode { get; set; }

    [XmlElement(DataType = "string", ElementName = "professionalBankAccountBank", IsNullable = true)]
    public string ProfessionalBankAccountBank { get; set; }

    [XmlElement(DataType = "string", ElementName = "privateBankAccountIban2", IsNullable = true)]
    public string PrivateBankAccountIban2 { get; set; }

    [XmlElement(DataType = "int", ElementName = "professionalBankAccountType", IsNullable = true)]
    public int? ProfessionalBankAccountType { get; set; }

    [XmlElement(DataType = "date", ElementName = "nextMedicalExaminationDate", IsNullable = true)]
    public DateTime? NextMedicalExaminationDate { get; set; }

    [XmlElement(DataType = "date", ElementName = "identityCardExpiryDate", IsNullable = true)]
    public DateTime? IdentityCardExpiryDate { get; set; }

    [XmlElement(DataType = "date", ElementName = "passportExpiryDate", IsNullable = true)]
    public DateTime? PassportExpiryDate { get; set; }

    [XmlElement(DataType = "date", ElementName = "nextTechnicalControlDate", IsNullable = true)]
    public DateTime? NextTechnicalControlDate { get; set; }

    [XmlElement(DataType = "int", ElementName = "distanceBetweenWorkAndHome", IsNullable = true)]
    public int? DistanceBetweenWorkAndHome { get; set; }

    [XmlElement(DataType = "string", ElementName = "passportNumber", IsNullable = true)]
    public string PassportNumber { get; set; }

    [XmlElement(DataType = "string", ElementName = "identityCardNumber", IsNullable = true)]
    public string IdentityCardNumber { get; set; }

    [XmlElement(DataType = "string", ElementName = "vehicleRegistrationNumber", IsNullable = true)]
    public string VehicleRegistrationNumber { get; set; }

    [XmlElement(DataType = "string", ElementName = "residencePermitNumber", IsNullable = true)]
    public string ResidencePermitNumber { get; set; }

    [XmlElement(DataType = "string", ElementName = "handicapCode", IsNullable = true)]
    public string HandicapCode { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "handicapped", IsNullable = true)]
    public bool? Handicapped { get; set; }

    [XmlElement(DataType = "date", ElementName = "handicapEndDate", IsNullable = true)]
    public DateTime? HandicapEndDate { get; set; }

    [XmlElement(DataType = "string", ElementName = "drivingLicenceNumber", IsNullable = true)]
    public string DrivingLicenceNumber { get; set; }

    [XmlElement(DataType = "string", ElementName = "nationalityCode", IsNullable = true)]
    public string NationalityCode { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "companyVehicle", IsNullable = true)]
    public bool? CompanyVehicle { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "foreignWorkerStatus", IsNullable = true)]
    public bool? ForeignWorkerStatus { get; set; }

    [XmlElement(DataType = "string", ElementName = "nationalityDescription", IsNullable = true)]
    public string NationalityDescription { get; set; }

    [XmlElement(DataType = "double", ElementName = "transitTimeBetweenWorkAndHome", IsNullable = true)]
    public double? TransitTimeBetweenWorkAndHome { get; set; }

    [XmlElement(DataType = "date", ElementName = "vehicleEndOfRentDate", IsNullable = true)]
    public DateTime? VehicleEndOfRentDate { get; set; }

    [XmlElement(DataType = "string", ElementName = "vehicleTypeCode", IsNullable = true)]
    public string VehicleTypeCode { get; set; }

    [XmlElement(DataType = "string", ElementName = "vehicleComment", IsNullable = true)]
    public string VehicleComment { get; set; }

    [XmlElement(DataType = "string", ElementName = "vehicleTypeDescription", IsNullable = true)]
    public string VehicleTypeDescription { get; set; }

    [XmlElement(DataType = "string", ElementName = "handicapDescription", IsNullable = true)]
    public string HandicapDescription { get; set; }

    [XmlElement(DataType = "string", ElementName = "handicapComment", IsNullable = true)]
    public string HandicapComment { get; set; }

    [XmlElement(DataType = "string", ElementName = "personnalBankAccountBBANCode2", IsNullable = true)]
    public string PersonnalBankAccountBBANCode2 { get; set; }

    [XmlElement(DataType = "string", ElementName = "previousMedicalExaminationComment", IsNullable = true)]
    public string PreviousMedicalExaminationComment { get; set; }

    [XmlElement(DataType = "int", ElementName = "drivingLicencePointNumber", IsNullable = true)]
    public int? DrivingLicencePointNumber { get; set; }

    [XmlElement(DataType = "string", ElementName = "previousMedicalExaminationStateAbbreviation", IsNullable = true)]
    public string PreviousMedicalExaminationStateAbbreviation { get; set; }

    [XmlElement(DataType = "string", ElementName = "personnalBankAccountBICSWIFTCode2", IsNullable = true)]
    public string PersonnalBankAccountBICSWIFTCode2 { get; set; }

    [XmlElement(DataType = "string", ElementName = "personnalBankAccountHolder", IsNullable = true)]
    public string PersonnalBankAccountHolder { get; set; }

    [XmlElement(DataType = "string", ElementName = "nextMedicalExaminationComment", IsNullable = true)]
    public string NextMedicalExaminationComment { get; set; }

    [XmlElement(DataType = "string", ElementName = "nextMedicalExaminationStateAbbreviation", IsNullable = true)]
    public string NextMedicalExaminationStateAbbreviation { get; set; }

    [XmlElement(DataType = "string", ElementName = "professionalBankAccountControlKey", IsNullable = true)]
    public string ProfessionalBankAccountControlKey { get; set; }

    [XmlElement(DataType = "string", ElementName = "personnalBankAccountControlKey2", IsNullable = true)]
    public string PersonnalBankAccountControlKey2 { get; set; }

    [XmlElement(DataType = "string", ElementName = "professionalBankAccountControlKey2", IsNullable = true)]
    public string ProfessionalBankAccountControlKey2 { get; set; }

    [XmlElement(DataType = "string", ElementName = "personnalBankAccountHolder2", IsNullable = true)]
    public string PersonnalBankAccountHolder2 { get; set; }

    [XmlElement(DataType = "string", ElementName = "personnalBankAccountControlKey", IsNullable = true)]
    public string PersonnalBankAccountControlKey { get; set; }
  }
}
