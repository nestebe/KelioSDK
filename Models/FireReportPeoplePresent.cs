
// Type: KelioSDK.Models.FireReportPeoplePresent




using KelioSDK.Common;
using System;
using System.Globalization;
using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "FireReportPeoplePresent")]
  public class FireReportPeoplePresent : ObjectBase
  {
    [XmlElement(DataType = "string", ElementName = "detailedDescription", IsNullable = true)]
    public string DetailedDescription { get; set; }

    [XmlElement(DataType = "date", ElementName = "reportStartDate", IsNullable = true)]
    public DateTime? ReportStartDate { get; set; }

    [XmlElement(DataType = "date", ElementName = "reportEndDate", IsNullable = true)]
    public DateTime? ReportEndDate { get; set; }

    [XmlIgnore]
    public TimeSpan? ReportStartHour { get; set; }

    [XmlElement(DataType = "string", ElementName = "reportStartHour", IsNullable = true)]
    public string ReportStartHourField
    {
      get
      {
        return !this.ReportStartHour.HasValue ? (string) null : this.ReportStartHour.Value.ToString("hh\\:mm\\:ss", (IFormatProvider) CultureInfo.InvariantCulture);
      }
      set
      {
        this.ReportStartHour = value == null ? new TimeSpan?() : new TimeSpan?(TimeSpan.ParseExact(value, "hh\\:mm\\:ss", (IFormatProvider) CultureInfo.InvariantCulture));
      }
    }

    [XmlIgnore]
    public TimeSpan? ReportEndHour { get; set; }

    [XmlElement(DataType = "string", ElementName = "reportEndHour", IsNullable = true)]
    public string ReportEndHourField
    {
      get
      {
        return !this.ReportEndHour.HasValue ? (string) null : this.ReportEndHour.Value.ToString("hh\\:mm\\:ss", (IFormatProvider) CultureInfo.InvariantCulture);
      }
      set
      {
        this.ReportEndHour = value == null ? new TimeSpan?() : new TimeSpan?(TimeSpan.ParseExact(value, "hh\\:mm\\:ss", (IFormatProvider) CultureInfo.InvariantCulture));
      }
    }

    [XmlElement(DataType = "int", ElementName = "usedFireReportConfigurationKey", IsNullable = true)]
    public int? UsedFireReportConfigurationKey { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "plannedExercise", IsNullable = true)]
    public bool? PlannedExercise { get; set; }

    [XmlElement(DataType = "string", ElementName = "usedFireReportConfigurationDescription", IsNullable = true)]
    public string UsedFireReportConfigurationDescription { get; set; }

    [XmlElement(DataType = "string", ElementName = "exerciseDuration", IsNullable = true)]
    public string ExerciseDuration { get; set; }

    [XmlElement(DataType = "int", ElementName = "fireReportMonitoringKey", IsNullable = true)]
    public int? FireReportMonitoringKey { get; set; }

    [XmlElement(DataType = "string", ElementName = "closedBy", IsNullable = true)]
    public string ClosedBy { get; set; }

    [XmlElement(DataType = "string", ElementName = "attachmentDescription", IsNullable = true)]
    public string AttachmentDescription { get; set; }
  }
}
