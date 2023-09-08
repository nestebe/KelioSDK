
// Type: KelioSDK.Models.ClockingDeclaration




using System;
using System.Globalization;
using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "ClockingDeclaration")]
  public class ClockingDeclaration : EmployeeInformation
  {
    [XmlElement(DataType = "date", ElementName = "date", IsNullable = true)]
    public DateTime? Date { get; set; }

    [XmlElement(DataType = "int", ElementName = "clockingDeclarationKey", IsNullable = true)]
    public int? ClockingDeclarationKey { get; set; }

    [XmlIgnore]
    public TimeSpan? Time { get; set; }

    [XmlElement(DataType = "string", ElementName = "time", IsNullable = true)]
    public string TimeField
    {
      get
      {
        return !this.Time.HasValue ? (string) null : this.Time.Value.ToString("hh\\:mm\\:ss", (IFormatProvider) CultureInfo.InvariantCulture);
      }
      set
      {
        this.Time = value == null ? new TimeSpan?() : new TimeSpan?(TimeSpan.ParseExact(value, "hh\\:mm\\:ss", (IFormatProvider) CultureInfo.InvariantCulture));
      }
    }

    [XmlElement(DataType = "string", ElementName = "comment", IsNullable = true)]
    public string Comment { get; set; }

    [XmlElement(DataType = "short", ElementName = "clockingTypeIndicator", IsNullable = true)]
    public short? ClockingTypeIndicator { get; set; }

    [XmlElement(DataType = "string", ElementName = "absenceTypeDescription", IsNullable = true)]
    public string AbsenceTypeDescription { get; set; }

    [XmlElement(DataType = "int", ElementName = "absenceTypeKey", IsNullable = true)]
    public int? AbsenceTypeKey { get; set; }

    [XmlElement(DataType = "string", ElementName = "absenceTypeAbbreviation", IsNullable = true)]
    public string AbsenceTypeAbbreviation { get; set; }

    [XmlElement(DataType = "string", ElementName = "validatorSurname", IsNullable = true)]
    public string ValidatorSurname { get; set; }

    [XmlElement(DataType = "string", ElementName = "validatorLogin", IsNullable = true)]
    public string ValidatorLogin { get; set; }

    [XmlElement(DataType = "int", ElementName = "validatorKey", IsNullable = true)]
    public int? ValidatorKey { get; set; }

    [XmlElement(DataType = "int", ElementName = "timePosition", IsNullable = true)]
    public int? TimePosition { get; set; }

    [XmlElement(DataType = "int", ElementName = "clockingKey", IsNullable = true)]
    public int? ClockingKey { get; set; }

    [XmlElement(DataType = "string", ElementName = "validatorIdentificationNumber", IsNullable = true)]
    public string ValidatorIdentificationNumber { get; set; }

    [XmlElement(DataType = "string", ElementName = "validatorFirstName", IsNullable = true)]
    public string ValidatorFirstName { get; set; }

    [XmlElement(DataType = "string", ElementName = "validatorBadgeCode", IsNullable = true)]
    public string ValidatorBadgeCode { get; set; }

    [XmlElement(DataType = "short", ElementName = "declarationState", IsNullable = true)]
    public short? DeclarationState { get; set; }
  }
}
