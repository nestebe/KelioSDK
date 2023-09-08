
// Type: KelioSDK.Models.EmployeeInformationAndCriterion




using System;
using System.Globalization;
using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "EmployeeInformationAndCriterion")]
  public class EmployeeInformationAndCriterion : EmployeeInformation
  {
    [XmlElement(DataType = "boolean", ElementName = "useDefaultModelEmployee", IsNullable = true)]
    public bool? UseDefaultModelEmployee { get; set; }

    [XmlElement(DataType = "date", ElementName = "currentAccessAuthorizationStartDate", IsNullable = true)]
    public DateTime? CurrentAccessAuthorizationStartDate { get; set; }

    [XmlElement(DataType = "date", ElementName = "currentAccessAuthorizationEndDate", IsNullable = true)]
    public DateTime? CurrentAccessAuthorizationEndDate { get; set; }

    [XmlElement(DataType = "string", ElementName = "defaultEmployeeIdentificationNumber", IsNullable = true)]
    public string DefaultEmployeeIdentificationNumber { get; set; }

    [XmlElement(DataType = "string", ElementName = "defaultEmployeeFirstName", IsNullable = true)]
    public string DefaultEmployeeFirstName { get; set; }

    [XmlElement(DataType = "date", ElementName = "takenIntoAccountPeriodStartDate", IsNullable = true)]
    public DateTime? TakenIntoAccountPeriodStartDate { get; set; }

    [XmlElement(DataType = "string", ElementName = "defaultEmployeeIdentificationCode", IsNullable = true)]
    public string DefaultEmployeeIdentificationCode { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "isTandAModuleEmployee", IsNullable = true)]
    public bool? IsTandAModuleEmployee { get; set; }

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

    [XmlElement(DataType = "boolean", ElementName = "isAccessModuleEmployee", IsNullable = true)]
    public bool? IsAccessModuleEmployee { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "generateBadge", IsNullable = true)]
    public bool? GenerateBadge { get; set; }

    [XmlIgnore]
    public TimeSpan? CurrentAccessAuthorizationEndTime { get; set; }

    [XmlElement(DataType = "string", ElementName = "currentAccessAuthorizationEndTime", IsNullable = true)]
    public string CurrentAccessAuthorizationEndTimeField
    {
      get
      {
        return !this.CurrentAccessAuthorizationEndTime.HasValue ? (string) null : this.CurrentAccessAuthorizationEndTime.Value.ToString("hh\\:mm\\:ss", (IFormatProvider) CultureInfo.InvariantCulture);
      }
      set
      {
        this.CurrentAccessAuthorizationEndTime = value == null ? new TimeSpan?() : new TimeSpan?(TimeSpan.ParseExact(value, "hh\\:mm\\:ss", (IFormatProvider) CultureInfo.InvariantCulture));
      }
    }

    [XmlIgnore]
    public TimeSpan? CurrentAccessAuthorizationStartTime { get; set; }

    [XmlElement(DataType = "string", ElementName = "currentAccessAuthorizationStartTime", IsNullable = true)]
    public string CurrentAccessAuthorizationStartTimeField
    {
      get
      {
        return !this.CurrentAccessAuthorizationStartTime.HasValue ? (string) null : this.CurrentAccessAuthorizationStartTime.Value.ToString("hh\\:mm\\:ss", (IFormatProvider) CultureInfo.InvariantCulture);
      }
      set
      {
        this.CurrentAccessAuthorizationStartTime = value == null ? new TimeSpan?() : new TimeSpan?(TimeSpan.ParseExact(value, "hh\\:mm\\:ss", (IFormatProvider) CultureInfo.InvariantCulture));
      }
    }
  }
}
