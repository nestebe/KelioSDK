
// Type: KelioSDK.Models.AbsenceRequest




using System;
using System.Globalization;
using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "AbsenceRequest")]
  public class AbsenceRequest : EmployeeInformation
  {
    [XmlElement(DataType = "string", ElementName = "validatorsIdentificationCode", IsNullable = true)]
    public string ValidatorsIdentificationCode { get; set; }

    [XmlElement(DataType = "string", ElementName = "comment", IsNullable = true)]
    public string Comment { get; set; }

    [XmlElement(DataType = "date", ElementName = "startDate", IsNullable = true)]
    public DateTime? StartDate { get; set; }

    [XmlElement(DataType = "date", ElementName = "endDate", IsNullable = true)]
    public DateTime? EndDate { get; set; }

    [XmlElement(DataType = "dateTime", ElementName = "lastModificationDate", IsNullable = true)]
    public DateTime? LastModificationDate { get; set; }

    [XmlElement(DataType = "int", ElementName = "requestType", IsNullable = true)]
    public int? RequestType { get; set; }

    [XmlIgnore]
    public TimeSpan? FirstEndTime { get; set; }

    [XmlElement(DataType = "string", ElementName = "firstEndTime", IsNullable = true)]
    public string FirstEndTimeField
    {
      get
      {
        return !this.FirstEndTime.HasValue ? (string) null : this.FirstEndTime.Value.ToString("hh\\:mm\\:ss", (IFormatProvider) CultureInfo.InvariantCulture);
      }
      set
      {
        this.FirstEndTime = value == null ? new TimeSpan?() : new TimeSpan?(TimeSpan.ParseExact(value, "hh\\:mm\\:ss", (IFormatProvider) CultureInfo.InvariantCulture));
      }
    }

    [XmlIgnore]
    public TimeSpan? SecondEndTime { get; set; }

    [XmlElement(DataType = "string", ElementName = "secondEndTime", IsNullable = true)]
    public string SecondEndTimeField
    {
      get
      {
        return !this.SecondEndTime.HasValue ? (string) null : this.SecondEndTime.Value.ToString("hh\\:mm\\:ss", (IFormatProvider) CultureInfo.InvariantCulture);
      }
      set
      {
        this.SecondEndTime = value == null ? new TimeSpan?() : new TimeSpan?(TimeSpan.ParseExact(value, "hh\\:mm\\:ss", (IFormatProvider) CultureInfo.InvariantCulture));
      }
    }

    [XmlElement(DataType = "date", ElementName = "creationDate", IsNullable = true)]
    public DateTime? CreationDate { get; set; }

    [XmlElement(DataType = "double", ElementName = "totalInHours", IsNullable = true)]
    public double? TotalInHours { get; set; }

    [XmlElement(DataType = "double", ElementName = "totalInDays", IsNullable = true)]
    public double? TotalInDays { get; set; }

    [XmlElement(DataType = "double", ElementName = "durationInHours", IsNullable = true)]
    public double? DurationInHours { get; set; }

    [XmlElement(DataType = "string", ElementName = "absenceTypeDescription", IsNullable = true)]
    public string AbsenceTypeDescription { get; set; }

    [XmlElement(DataType = "int", ElementName = "absenceTypeKey", IsNullable = true)]
    public int? AbsenceTypeKey { get; set; }

    [XmlElement(DataType = "string", ElementName = "absenceTypeAbbreviation", IsNullable = true)]
    public string AbsenceTypeAbbreviation { get; set; }

    [XmlElement(DataType = "double", ElementName = "durationInDays", IsNullable = true)]
    public double? DurationInDays { get; set; }

    [XmlIgnore]
    public TimeSpan? FirstStartTime { get; set; }

    [XmlElement(DataType = "string", ElementName = "firstStartTime", IsNullable = true)]
    public string FirstStartTimeField
    {
      get
      {
        return !this.FirstStartTime.HasValue ? (string) null : this.FirstStartTime.Value.ToString("hh\\:mm\\:ss", (IFormatProvider) CultureInfo.InvariantCulture);
      }
      set
      {
        this.FirstStartTime = value == null ? new TimeSpan?() : new TimeSpan?(TimeSpan.ParseExact(value, "hh\\:mm\\:ss", (IFormatProvider) CultureInfo.InvariantCulture));
      }
    }

    [XmlIgnore]
    public TimeSpan? SecondStartTime { get; set; }

    [XmlElement(DataType = "string", ElementName = "secondStartTime", IsNullable = true)]
    public string SecondStartTimeField
    {
      get
      {
        return !this.SecondStartTime.HasValue ? (string) null : this.SecondStartTime.Value.ToString("hh\\:mm\\:ss", (IFormatProvider) CultureInfo.InvariantCulture);
      }
      set
      {
        this.SecondStartTime = value == null ? new TimeSpan?() : new TimeSpan?(TimeSpan.ParseExact(value, "hh\\:mm\\:ss", (IFormatProvider) CultureInfo.InvariantCulture));
      }
    }

    [XmlElement(DataType = "int", ElementName = "secondEndTimePosition", IsNullable = true)]
    public int? SecondEndTimePosition { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "startInTheMorning", IsNullable = true)]
    public bool? StartInTheMorning { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "endingTheAfternoon", IsNullable = true)]
    public bool? EndingTheAfternoon { get; set; }

    [XmlElement(DataType = "int", ElementName = "firstStartTimePosition", IsNullable = true)]
    public int? FirstStartTimePosition { get; set; }

    [XmlElement(DataType = "int", ElementName = "secondStartTimePosition", IsNullable = true)]
    public int? SecondStartTimePosition { get; set; }

    [XmlElement(DataType = "int", ElementName = "firstEndTimePosition", IsNullable = true)]
    public int? FirstEndTimePosition { get; set; }

    [XmlElement(DataType = "int", ElementName = "requestState", IsNullable = true)]
    public int? RequestState { get; set; }

    [XmlElement(DataType = "string", ElementName = "validatorsKeys", IsNullable = true)]
    public string ValidatorsKeys { get; set; }

    [XmlElement(DataType = "string", ElementName = "validatorsSurnames", IsNullable = true)]
    public string ValidatorsSurnames { get; set; }

    [XmlElement(DataType = "int", ElementName = "absenceRequestKey", IsNullable = true)]
    public int? AbsenceRequestKey { get; set; }

    [XmlElement(DataType = "string", ElementName = "validatorsBadgeCodes", IsNullable = true)]
    public string ValidatorsBadgeCodes { get; set; }

    [XmlElement(DataType = "string", ElementName = "validatorsLogins", IsNullable = true)]
    public string ValidatorsLogins { get; set; }

    [XmlElement(DataType = "string", ElementName = "validatorsIdentificationNumbers", IsNullable = true)]
    public string ValidatorsIdentificationNumbers { get; set; }

    [XmlElement(DataType = "string", ElementName = "validatorsFirstNames", IsNullable = true)]
    public string ValidatorsFirstNames { get; set; }
  }
}
