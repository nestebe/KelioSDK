
// Type: KelioSDK.Models.DailyScheduleAssignment




using System;
using System.Globalization;
using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "DailyScheduleAssignment")]
  public class DailyScheduleAssignment : EmployeeInformation
  {
    [XmlElement(DataType = "boolean", ElementName = "contractedFromWorkingPeriods", IsNullable = true)]
    public bool? ContractedFromWorkingPeriods { get; set; }

    [XmlElement(DataType = "double", ElementName = "contractedTime", IsNullable = true)]
    public double? ContractedTime { get; set; }

    [XmlElement(DataType = "double", ElementName = "morningContractedTime", IsNullable = true)]
    public double? MorningContractedTime { get; set; }

    [XmlElement(DataType = "string", ElementName = "comment", IsNullable = true)]
    public string Comment { get; set; }

    [XmlElement(DataType = "double", ElementName = "afternoonContractedTime", IsNullable = true)]
    public double? AfternoonContractedTime { get; set; }

    [XmlElement(DataType = "date", ElementName = "assignmentDate", IsNullable = true)]
    public DateTime? AssignmentDate { get; set; }

    [XmlElement(DataType = "string", ElementName = "dailyScheduleAbbreviation", IsNullable = true)]
    public string DailyScheduleAbbreviation { get; set; }

    [XmlElement(DataType = "string", ElementName = "dailyScheduleDescription", IsNullable = true)]
    public string DailyScheduleDescription { get; set; }

    [XmlElement(DataType = "int", ElementName = "dailyScheduleKey", IsNullable = true)]
    public int? DailyScheduleKey { get; set; }

    [XmlElement(DataType = "string", ElementName = "scheduleAbbreviation", IsNullable = true)]
    public string ScheduleAbbreviation { get; set; }

    [XmlElement(DataType = "int", ElementName = "calculationModeContractedSchedule", IsNullable = true)]
    public int? CalculationModeContractedSchedule { get; set; }

    [XmlIgnore]
    public TimeSpan? HalfDayTime { get; set; }

    [XmlElement(DataType = "string", ElementName = "halfDayTime", IsNullable = true)]
    public string HalfDayTimeField
    {
      get
      {
        return !this.HalfDayTime.HasValue ? (string) null : this.HalfDayTime.Value.ToString("hh\\:mm\\:ss", (IFormatProvider) CultureInfo.InvariantCulture);
      }
      set
      {
        this.HalfDayTime = value == null ? new TimeSpan?() : new TimeSpan?(TimeSpan.ParseExact(value, "hh\\:mm\\:ss", (IFormatProvider) CultureInfo.InvariantCulture));
      }
    }

    [XmlIgnore]
    public TimeSpan? FirstWorkingPeriodStartTime { get; set; }

    [XmlElement(DataType = "string", ElementName = "firstWorkingPeriodStartTime", IsNullable = true)]
    public string FirstWorkingPeriodStartTimeField
    {
      get
      {
        return !this.FirstWorkingPeriodStartTime.HasValue ? (string) null : this.FirstWorkingPeriodStartTime.Value.ToString("hh\\:mm\\:ss", (IFormatProvider) CultureInfo.InvariantCulture);
      }
      set
      {
        this.FirstWorkingPeriodStartTime = value == null ? new TimeSpan?() : new TimeSpan?(TimeSpan.ParseExact(value, "hh\\:mm\\:ss", (IFormatProvider) CultureInfo.InvariantCulture));
      }
    }

    [XmlIgnore]
    public TimeSpan? FourthWorkingPeriodEndTime { get; set; }

    [XmlElement(DataType = "string", ElementName = "fourthWorkingPeriodEndTime", IsNullable = true)]
    public string FourthWorkingPeriodEndTimeField
    {
      get
      {
        return !this.FourthWorkingPeriodEndTime.HasValue ? (string) null : this.FourthWorkingPeriodEndTime.Value.ToString("hh\\:mm\\:ss", (IFormatProvider) CultureInfo.InvariantCulture);
      }
      set
      {
        this.FourthWorkingPeriodEndTime = value == null ? new TimeSpan?() : new TimeSpan?(TimeSpan.ParseExact(value, "hh\\:mm\\:ss", (IFormatProvider) CultureInfo.InvariantCulture));
      }
    }

    [XmlIgnore]
    public TimeSpan? FirstWorkingPeriodEndTime { get; set; }

    [XmlElement(DataType = "string", ElementName = "firstWorkingPeriodEndTime", IsNullable = true)]
    public string FirstWorkingPeriodEndTimeField
    {
      get
      {
        return !this.FirstWorkingPeriodEndTime.HasValue ? (string) null : this.FirstWorkingPeriodEndTime.Value.ToString("hh\\:mm\\:ss", (IFormatProvider) CultureInfo.InvariantCulture);
      }
      set
      {
        this.FirstWorkingPeriodEndTime = value == null ? new TimeSpan?() : new TimeSpan?(TimeSpan.ParseExact(value, "hh\\:mm\\:ss", (IFormatProvider) CultureInfo.InvariantCulture));
      }
    }

    [XmlElement(DataType = "int", ElementName = "thirdWorkingPeriodStartTimePosition", IsNullable = true)]
    public int? ThirdWorkingPeriodStartTimePosition { get; set; }

    [XmlIgnore]
    public TimeSpan? ThirdWorkingPeriodStartTime { get; set; }

    [XmlElement(DataType = "string", ElementName = "thirdWorkingPeriodStartTime", IsNullable = true)]
    public string ThirdWorkingPeriodStartTimeField
    {
      get
      {
        return !this.ThirdWorkingPeriodStartTime.HasValue ? (string) null : this.ThirdWorkingPeriodStartTime.Value.ToString("hh\\:mm\\:ss", (IFormatProvider) CultureInfo.InvariantCulture);
      }
      set
      {
        this.ThirdWorkingPeriodStartTime = value == null ? new TimeSpan?() : new TimeSpan?(TimeSpan.ParseExact(value, "hh\\:mm\\:ss", (IFormatProvider) CultureInfo.InvariantCulture));
      }
    }

    [XmlElement(DataType = "int", ElementName = "firstWorkingPeriodStartTimePosition", IsNullable = true)]
    public int? FirstWorkingPeriodStartTimePosition { get; set; }

    [XmlElement(DataType = "int", ElementName = "secondWorkingPeriodStartTimePosition", IsNullable = true)]
    public int? SecondWorkingPeriodStartTimePosition { get; set; }

    [XmlIgnore]
    public TimeSpan? ThirdWorkingPeriodEndTime { get; set; }

    [XmlElement(DataType = "string", ElementName = "thirdWorkingPeriodEndTime", IsNullable = true)]
    public string ThirdWorkingPeriodEndTimeField
    {
      get
      {
        return !this.ThirdWorkingPeriodEndTime.HasValue ? (string) null : this.ThirdWorkingPeriodEndTime.Value.ToString("hh\\:mm\\:ss", (IFormatProvider) CultureInfo.InvariantCulture);
      }
      set
      {
        this.ThirdWorkingPeriodEndTime = value == null ? new TimeSpan?() : new TimeSpan?(TimeSpan.ParseExact(value, "hh\\:mm\\:ss", (IFormatProvider) CultureInfo.InvariantCulture));
      }
    }

    [XmlElement(DataType = "int", ElementName = "fourthWorkingPeriodStartTimePosition", IsNullable = true)]
    public int? FourthWorkingPeriodStartTimePosition { get; set; }

    [XmlIgnore]
    public TimeSpan? SecondWorkingPeriodStartTime { get; set; }

    [XmlElement(DataType = "string", ElementName = "secondWorkingPeriodStartTime", IsNullable = true)]
    public string SecondWorkingPeriodStartTimeField
    {
      get
      {
        return !this.SecondWorkingPeriodStartTime.HasValue ? (string) null : this.SecondWorkingPeriodStartTime.Value.ToString("hh\\:mm\\:ss", (IFormatProvider) CultureInfo.InvariantCulture);
      }
      set
      {
        this.SecondWorkingPeriodStartTime = value == null ? new TimeSpan?() : new TimeSpan?(TimeSpan.ParseExact(value, "hh\\:mm\\:ss", (IFormatProvider) CultureInfo.InvariantCulture));
      }
    }

    [XmlElement(DataType = "int", ElementName = "fifthWorkingPeriodStartTimePosition", IsNullable = true)]
    public int? FifthWorkingPeriodStartTimePosition { get; set; }

    [XmlIgnore]
    public TimeSpan? FifthWorkingPeriodStartTime { get; set; }

    [XmlElement(DataType = "string", ElementName = "fifthWorkingPeriodStartTime", IsNullable = true)]
    public string FifthWorkingPeriodStartTimeField
    {
      get
      {
        return !this.FifthWorkingPeriodStartTime.HasValue ? (string) null : this.FifthWorkingPeriodStartTime.Value.ToString("hh\\:mm\\:ss", (IFormatProvider) CultureInfo.InvariantCulture);
      }
      set
      {
        this.FifthWorkingPeriodStartTime = value == null ? new TimeSpan?() : new TimeSpan?(TimeSpan.ParseExact(value, "hh\\:mm\\:ss", (IFormatProvider) CultureInfo.InvariantCulture));
      }
    }

    [XmlIgnore]
    public TimeSpan? SecondWorkingPeriodEndTime { get; set; }

    [XmlElement(DataType = "string", ElementName = "secondWorkingPeriodEndTime", IsNullable = true)]
    public string SecondWorkingPeriodEndTimeField
    {
      get
      {
        return !this.SecondWorkingPeriodEndTime.HasValue ? (string) null : this.SecondWorkingPeriodEndTime.Value.ToString("hh\\:mm\\:ss", (IFormatProvider) CultureInfo.InvariantCulture);
      }
      set
      {
        this.SecondWorkingPeriodEndTime = value == null ? new TimeSpan?() : new TimeSpan?(TimeSpan.ParseExact(value, "hh\\:mm\\:ss", (IFormatProvider) CultureInfo.InvariantCulture));
      }
    }

    [XmlIgnore]
    public TimeSpan? FourthWorkingPeriodStartTime { get; set; }

    [XmlElement(DataType = "string", ElementName = "fourthWorkingPeriodStartTime", IsNullable = true)]
    public string FourthWorkingPeriodStartTimeField
    {
      get
      {
        return !this.FourthWorkingPeriodStartTime.HasValue ? (string) null : this.FourthWorkingPeriodStartTime.Value.ToString("hh\\:mm\\:ss", (IFormatProvider) CultureInfo.InvariantCulture);
      }
      set
      {
        this.FourthWorkingPeriodStartTime = value == null ? new TimeSpan?() : new TimeSpan?(TimeSpan.ParseExact(value, "hh\\:mm\\:ss", (IFormatProvider) CultureInfo.InvariantCulture));
      }
    }

    [XmlIgnore]
    public TimeSpan? FifthWorkingPeriodEndTime { get; set; }

    [XmlElement(DataType = "string", ElementName = "fifthWorkingPeriodEndTime", IsNullable = true)]
    public string FifthWorkingPeriodEndTimeField
    {
      get
      {
        return !this.FifthWorkingPeriodEndTime.HasValue ? (string) null : this.FifthWorkingPeriodEndTime.Value.ToString("hh\\:mm\\:ss", (IFormatProvider) CultureInfo.InvariantCulture);
      }
      set
      {
        this.FifthWorkingPeriodEndTime = value == null ? new TimeSpan?() : new TimeSpan?(TimeSpan.ParseExact(value, "hh\\:mm\\:ss", (IFormatProvider) CultureInfo.InvariantCulture));
      }
    }

    [XmlElement(DataType = "string", ElementName = "scheduleDescription", IsNullable = true)]
    public string ScheduleDescription { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "assignementByException", IsNullable = true)]
    public bool? AssignementByException { get; set; }

    [XmlElement(DataType = "int", ElementName = "firstWorkingPeriodEndTimePosition", IsNullable = true)]
    public int? FirstWorkingPeriodEndTimePosition { get; set; }

    [XmlElement(DataType = "int", ElementName = "secondWorkingPeriodEndTimePosition", IsNullable = true)]
    public int? SecondWorkingPeriodEndTimePosition { get; set; }

    [XmlElement(DataType = "int", ElementName = "thirdWorkingPeriodEndTimePosition", IsNullable = true)]
    public int? ThirdWorkingPeriodEndTimePosition { get; set; }

    [XmlElement(DataType = "int", ElementName = "fourthWorkingPeriodEndTimePosition", IsNullable = true)]
    public int? FourthWorkingPeriodEndTimePosition { get; set; }

    [XmlElement(DataType = "int", ElementName = "fifthWorkingPeriodEndTimePosition", IsNullable = true)]
    public int? FifthWorkingPeriodEndTimePosition { get; set; }

    [XmlIgnore]
    public TimeSpan? NightStartTime { get; set; }

    [XmlElement(DataType = "string", ElementName = "nightStartTime", IsNullable = true)]
    public string NightStartTimeField
    {
      get
      {
        return !this.NightStartTime.HasValue ? (string) null : this.NightStartTime.Value.ToString("hh\\:mm\\:ss", (IFormatProvider) CultureInfo.InvariantCulture);
      }
      set
      {
        this.NightStartTime = value == null ? new TimeSpan?() : new TimeSpan?(TimeSpan.ParseExact(value, "hh\\:mm\\:ss", (IFormatProvider) CultureInfo.InvariantCulture));
      }
    }
  }
}
