
// Type: KelioSDK.Models.DailySchedule




using KelioSDK.Common;
using System;
using System.Globalization;
using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "DailySchedule")]
  public class DailySchedule : ObjectBase
  {
    [XmlElement(DataType = "int", ElementName = "halfDayOffColour", IsNullable = true)]
    public int? HalfDayOffColour { get; set; }

    [XmlElement(DataType = "double", ElementName = "morningContractedTime", IsNullable = true)]
    public double? MorningContractedTime { get; set; }

    [XmlElement(DataType = "double", ElementName = "afternoonContractedTime", IsNullable = true)]
    public double? AfternoonContractedTime { get; set; }

    [XmlElement(DataType = "int", ElementName = "colour", IsNullable = true)]
    public int? Colour { get; set; }

    [XmlElement(DataType = "short", ElementName = "grid", IsNullable = true)]
    public short? Grid { get; set; }

    [XmlElement(DataType = "short", ElementName = "dayType", IsNullable = true)]
    public short? DayType { get; set; }

    [XmlIgnore]
    public TimeSpan? EndOfTheDayTime { get; set; }

    [XmlElement(DataType = "string", ElementName = "endOfTheDayTime", IsNullable = true)]
    public string EndOfTheDayTimeField
    {
      get
      {
        return !this.EndOfTheDayTime.HasValue ? (string) null : this.EndOfTheDayTime.Value.ToString("hh\\:mm\\:ss", (IFormatProvider) CultureInfo.InvariantCulture);
      }
      set
      {
        this.EndOfTheDayTime = value == null ? new TimeSpan?() : new TimeSpan?(TimeSpan.ParseExact(value, "hh\\:mm\\:ss", (IFormatProvider) CultureInfo.InvariantCulture));
      }
    }

    [XmlElement(DataType = "double", ElementName = "dayContractedTime", IsNullable = true)]
    public double? DayContractedTime { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "searchUsingAbbreviation", IsNullable = true)]
    public bool? SearchUsingAbbreviation { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "searchUsingDescription", IsNullable = true)]
    public bool? SearchUsingDescription { get; set; }

    [XmlElement(DataType = "int", ElementName = "dailyScheduleKey", IsNullable = true)]
    public int? DailyScheduleKey { get; set; }

    [XmlElement(DataType = "double", ElementName = "nightStartTimeRelativeDelta", IsNullable = true)]
    public double? NightStartTimeRelativeDelta { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "publicHolidayDifferentDailySchedule", IsNullable = true)]
    public bool? PublicHolidayDifferentDailySchedule { get; set; }

    [XmlElement(DataType = "double", ElementName = "dayContractedTimeGap", IsNullable = true)]
    public double? DayContractedTimeGap { get; set; }

    [XmlElement(DataType = "double", ElementName = "morningContractedTimeGap", IsNullable = true)]
    public double? MorningContractedTimeGap { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "contractedTimeIsRelative", IsNullable = true)]
    public bool? ContractedTimeIsRelative { get; set; }

    [XmlElement(DataType = "string", ElementName = "publicHolidayDailyScheduleAbbreviation", IsNullable = true)]
    public string PublicHolidayDailyScheduleAbbreviation { get; set; }

    [XmlIgnore]
    public TimeSpan? StartOfTheDayTime { get; set; }

    [XmlElement(DataType = "string", ElementName = "startOfTheDayTime", IsNullable = true)]
    public string StartOfTheDayTimeField
    {
      get
      {
        return !this.StartOfTheDayTime.HasValue ? (string) null : this.StartOfTheDayTime.Value.ToString("hh\\:mm\\:ss", (IFormatProvider) CultureInfo.InvariantCulture);
      }
      set
      {
        this.StartOfTheDayTime = value == null ? new TimeSpan?() : new TimeSpan?(TimeSpan.ParseExact(value, "hh\\:mm\\:ss", (IFormatProvider) CultureInfo.InvariantCulture));
      }
    }

    [XmlElement(DataType = "string", ElementName = "defaultDailyScheduleDescription", IsNullable = true)]
    public string DefaultDailyScheduleDescription { get; set; }

    [XmlElement(DataType = "string", ElementName = "defaultDailyScheduleAbbreviation", IsNullable = true)]
    public string DefaultDailyScheduleAbbreviation { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "generateClocking", IsNullable = true)]
    public bool? GenerateClocking { get; set; }

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

    [XmlElement(DataType = "boolean", ElementName = "anomalyIfWork", IsNullable = true)]
    public bool? AnomalyIfWork { get; set; }

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

    [XmlElement(DataType = "string", ElementName = "selectedGroupOfAbsence", IsNullable = true)]
    public string SelectedGroupOfAbsence { get; set; }

    [XmlElement(DataType = "short", ElementName = "thirdWorkingPeriodStartTimePosition", IsNullable = true)]
    public short? ThirdWorkingPeriodStartTimePosition { get; set; }

    [XmlElement(DataType = "double", ElementName = "totalInDaysForAnAbsence", IsNullable = true)]
    public double? TotalInDaysForAnAbsence { get; set; }

    [XmlElement(DataType = "short", ElementName = "halfDayOffgrid", IsNullable = true)]
    public short? HalfDayOffgrid { get; set; }

    [XmlElement(DataType = "short", ElementName = "dailyScheduleType", IsNullable = true)]
    public short? DailyScheduleType { get; set; }

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

    [XmlElement(DataType = "short", ElementName = "firstWorkingPeriodStartTimePosition", IsNullable = true)]
    public short? FirstWorkingPeriodStartTimePosition { get; set; }

    [XmlElement(DataType = "short", ElementName = "secondWorkingPeriodStartTimePosition", IsNullable = true)]
    public short? SecondWorkingPeriodStartTimePosition { get; set; }

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

    [XmlElement(DataType = "short", ElementName = "fourthWorkingPeriodStartTimePosition", IsNullable = true)]
    public short? FourthWorkingPeriodStartTimePosition { get; set; }

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

    [XmlElement(DataType = "short", ElementName = "fifthWorkingPeriodStartTimePosition", IsNullable = true)]
    public short? FifthWorkingPeriodStartTimePosition { get; set; }

    [XmlElement(DataType = "short", ElementName = "nightStartTimePosition", IsNullable = true)]
    public short? NightStartTimePosition { get; set; }

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

    [XmlElement(DataType = "boolean", ElementName = "duplicateFromModel", IsNullable = true)]
    public bool? DuplicateFromModel { get; set; }

    [XmlElement(DataType = "int", ElementName = "startOfTheDayTimeRelativeIndex", IsNullable = true)]
    public int? StartOfTheDayTimeRelativeIndex { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "sheduleEnteredOnTerminal", IsNullable = true)]
    public bool? SheduleEnteredOnTerminal { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "halfDayOffCalculation", IsNullable = true)]
    public bool? HalfDayOffCalculation { get; set; }

    [XmlElement(DataType = "short", ElementName = "startOfTheDayTimePosition", IsNullable = true)]
    public short? StartOfTheDayTimePosition { get; set; }

    [XmlElement(DataType = "short", ElementName = "halfDayTimePosition", IsNullable = true)]
    public short? HalfDayTimePosition { get; set; }

    [XmlElement(DataType = "double", ElementName = "requiredTimeForAnAbsence", IsNullable = true)]
    public double? RequiredTimeForAnAbsence { get; set; }

    [XmlElement(DataType = "short", ElementName = "endOfTheDayTimePosition", IsNullable = true)]
    public short? EndOfTheDayTimePosition { get; set; }

    [XmlElement(DataType = "string", ElementName = "publicHolidayDailyScheduleDescription", IsNullable = true)]
    public string PublicHolidayDailyScheduleDescription { get; set; }

    [XmlElement(DataType = "double", ElementName = "requiredTimeForAnAbsenceDelta", IsNullable = true)]
    public double? RequiredTimeForAnAbsenceDelta { get; set; }

    [XmlElement(DataType = "double", ElementName = "afternoonContractedTimeGap", IsNullable = true)]
    public double? AfternoonContractedTimeGap { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "maximumTimeIsRelative", IsNullable = true)]
    public bool? MaximumTimeIsRelative { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "minimumTimeIsRelative", IsNullable = true)]
    public bool? MinimumTimeIsRelative { get; set; }

    [XmlElement(DataType = "double", ElementName = "endOfTheDayTimeRelativeDelta", IsNullable = true)]
    public double? EndOfTheDayTimeRelativeDelta { get; set; }

    [XmlElement(DataType = "int", ElementName = "endOfTheDayTimeRelativeIndex", IsNullable = true)]
    public int? EndOfTheDayTimeRelativeIndex { get; set; }

    [XmlElement(DataType = "int", ElementName = "halfDayTimeRelativeIndex", IsNullable = true)]
    public int? HalfDayTimeRelativeIndex { get; set; }

    [XmlElement(DataType = "double", ElementName = "halfDayTimeRelativeDelta", IsNullable = true)]
    public double? HalfDayTimeRelativeDelta { get; set; }

    [XmlElement(DataType = "double", ElementName = "startOfTheDayTimeRelativeDelta", IsNullable = true)]
    public double? StartOfTheDayTimeRelativeDelta { get; set; }

    [XmlElement(DataType = "int", ElementName = "nightStartTimeRelativeIndex", IsNullable = true)]
    public int? NightStartTimeRelativeIndex { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "mergedDayDisplayForPlanning", IsNullable = true)]
    public bool? MergedDayDisplayForPlanning { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "weekday", IsNullable = true)]
    public bool? Weekday { get; set; }

    [XmlElement(DataType = "short", ElementName = "firstWorkingPeriodEndTimePosition", IsNullable = true)]
    public short? FirstWorkingPeriodEndTimePosition { get; set; }

    [XmlElement(DataType = "short", ElementName = "secondWorkingPeriodEndTimePosition", IsNullable = true)]
    public short? SecondWorkingPeriodEndTimePosition { get; set; }

    [XmlElement(DataType = "short", ElementName = "thirdWorkingPeriodEndTimePosition", IsNullable = true)]
    public short? ThirdWorkingPeriodEndTimePosition { get; set; }

    [XmlElement(DataType = "short", ElementName = "fourthWorkingPeriodEndTimePosition", IsNullable = true)]
    public short? FourthWorkingPeriodEndTimePosition { get; set; }

    [XmlElement(DataType = "short", ElementName = "fifthWorkingPeriodEndTimePosition", IsNullable = true)]
    public short? FifthWorkingPeriodEndTimePosition { get; set; }

    [XmlElement(DataType = "double", ElementName = "maximumTime", IsNullable = true)]
    public double? MaximumTime { get; set; }

    [XmlElement(DataType = "double", ElementName = "minimumTime", IsNullable = true)]
    public double? MinimumTime { get; set; }

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

    [XmlElement(DataType = "string", ElementName = "dailyScheduleDescription", IsNullable = true)]
    public string DailyScheduleDescription { get; set; }

    [XmlElement(DataType = "string", ElementName = "dailyScheduleAbbreviation", IsNullable = true)]
    public string DailyScheduleAbbreviation { get; set; }
  }
}
