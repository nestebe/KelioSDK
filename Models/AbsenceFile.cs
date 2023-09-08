
// Type: KelioSDK.Models.AbsenceFile




using System;
using System.Globalization;
using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "AbsenceFile")]
  public class AbsenceFile : EmployeeInformation
  {
    [XmlElement(DataType = "boolean", ElementName = "limitedToAPeriod", IsNullable = true)]
    public bool? LimitedToAPeriod { get; set; }

    [XmlElement(DataType = "int", ElementName = "repetitiveAbsencePeriod", IsNullable = true)]
    public int? RepetitiveAbsencePeriod { get; set; }

    [XmlElement(DataType = "string", ElementName = "comment", IsNullable = true)]
    public string Comment { get; set; }

    [XmlElement(DataType = "date", ElementName = "startDate", IsNullable = true)]
    public DateTime? StartDate { get; set; }

    [XmlElement(DataType = "date", ElementName = "endDate", IsNullable = true)]
    public DateTime? EndDate { get; set; }

    [XmlElement(DataType = "date", ElementName = "resumptionWorkEarlyDate", IsNullable = true)]
    public DateTime? ResumptionWorkEarlyDate { get; set; }

    [XmlElement(DataType = "date", ElementName = "eventObservingDate", IsNullable = true)]
    public DateTime? EventObservingDate { get; set; }

    [XmlElement(DataType = "date", ElementName = "initialNoticeCessationWorkDate", IsNullable = true)]
    public DateTime? InitialNoticeCessationWorkDate { get; set; }

    [XmlElement(DataType = "date", ElementName = "lastWorkingDayDate", IsNullable = true)]
    public DateTime? LastWorkingDayDate { get; set; }

    [XmlElement(DataType = "date", ElementName = "resumptionWorkDate", IsNullable = true)]
    public DateTime? ResumptionWorkDate { get; set; }

    [XmlElement(DataType = "dateTime", ElementName = "lastModificationDate", IsNullable = true)]
    public DateTime? LastModificationDate { get; set; }

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

    [XmlElement(DataType = "int", ElementName = "numberOfAbsenceDays", IsNullable = true)]
    public int? NumberOfAbsenceDays { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "noticeCessationWorkExtension", IsNullable = true)]
    public bool? NoticeCessationWorkExtension { get; set; }

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

    [XmlElement(DataType = "int", ElementName = "absenceFileKey", IsNullable = true)]
    public int? AbsenceFileKey { get; set; }

    [XmlElement(DataType = "int", ElementName = "secondEndTimePosition", IsNullable = true)]
    public int? SecondEndTimePosition { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "startInTheMorning", IsNullable = true)]
    public bool? StartInTheMorning { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "fromClockings", IsNullable = true)]
    public bool? FromClockings { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "endingTheAfternoon", IsNullable = true)]
    public bool? EndingTheAfternoon { get; set; }

    [XmlElement(DataType = "int", ElementName = "firstStartTimePosition", IsNullable = true)]
    public int? FirstStartTimePosition { get; set; }

    [XmlElement(DataType = "int", ElementName = "secondStartTimePosition", IsNullable = true)]
    public int? SecondStartTimePosition { get; set; }

    [XmlElement(DataType = "int", ElementName = "firstEndTimePosition", IsNullable = true)]
    public int? FirstEndTimePosition { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "existRelatedDocument", IsNullable = true)]
    public bool? ExistRelatedDocument { get; set; }
  }
}
