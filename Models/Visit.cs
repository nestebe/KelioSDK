
// Type: KelioSDK.Models.Visit




using KelioSDK.Common;
using System;
using System.Globalization;
using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "Visit")]
  public class Visit : ObjectBase
  {
    [XmlElement(DataType = "date", ElementName = "completedVisitStartDate", IsNullable = true)]
    public DateTime? CompletedVisitStartDate { get; set; }

    [XmlElement(DataType = "string", ElementName = "visitPurposeComment", IsNullable = true)]
    public string VisitPurposeComment { get; set; }

    [XmlIgnore]
    public TimeSpan? CompletedVisitStartTime { get; set; }

    [XmlElement(DataType = "string", ElementName = "completedVisitStartTime", IsNullable = true)]
    public string CompletedVisitStartTimeField
    {
      get
      {
        return !this.CompletedVisitStartTime.HasValue ? (string) null : this.CompletedVisitStartTime.Value.ToString("hh\\:mm\\:ss", (IFormatProvider) CultureInfo.InvariantCulture);
      }
      set
      {
        this.CompletedVisitStartTime = value == null ? new TimeSpan?() : new TimeSpan?(TimeSpan.ParseExact(value, "hh\\:mm\\:ss", (IFormatProvider) CultureInfo.InvariantCulture));
      }
    }

    [XmlElement(DataType = "string", ElementName = "completedVisitComment", IsNullable = true)]
    public string CompletedVisitComment { get; set; }

    [XmlIgnore]
    public TimeSpan? PlannedVisitStartTime { get; set; }

    [XmlElement(DataType = "string", ElementName = "plannedVisitStartTime", IsNullable = true)]
    public string PlannedVisitStartTimeField
    {
      get
      {
        return !this.PlannedVisitStartTime.HasValue ? (string) null : this.PlannedVisitStartTime.Value.ToString("hh\\:mm\\:ss", (IFormatProvider) CultureInfo.InvariantCulture);
      }
      set
      {
        this.PlannedVisitStartTime = value == null ? new TimeSpan?() : new TimeSpan?(TimeSpan.ParseExact(value, "hh\\:mm\\:ss", (IFormatProvider) CultureInfo.InvariantCulture));
      }
    }

    [XmlElement(DataType = "string", ElementName = "visitorFirstname", IsNullable = true)]
    public string VisitorFirstname { get; set; }

    [XmlElement(DataType = "string", ElementName = "visitorCompany", IsNullable = true)]
    public string VisitorCompany { get; set; }

    [XmlElement(DataType = "string", ElementName = "visitorSurname", IsNullable = true)]
    public string VisitorSurname { get; set; }

    [XmlElement(DataType = "string", ElementName = "sectionName", IsNullable = true)]
    public string SectionName { get; set; }

    [XmlIgnore]
    public TimeSpan? CompletedVisitEndTime { get; set; }

    [XmlElement(DataType = "string", ElementName = "completedVisitEndTime", IsNullable = true)]
    public string CompletedVisitEndTimeField
    {
      get
      {
        return !this.CompletedVisitEndTime.HasValue ? (string) null : this.CompletedVisitEndTime.Value.ToString("hh\\:mm\\:ss", (IFormatProvider) CultureInfo.InvariantCulture);
      }
      set
      {
        this.CompletedVisitEndTime = value == null ? new TimeSpan?() : new TimeSpan?(TimeSpan.ParseExact(value, "hh\\:mm\\:ss", (IFormatProvider) CultureInfo.InvariantCulture));
      }
    }

    [XmlElement(DataType = "boolean", ElementName = "authorizedOvertake", IsNullable = true)]
    public bool? AuthorizedOvertake { get; set; }

    [XmlElement(DataType = "string", ElementName = "badgeCode", IsNullable = true)]
    public string BadgeCode { get; set; }

    [XmlIgnore]
    public TimeSpan? PlannedVisitEndTime { get; set; }

    [XmlElement(DataType = "string", ElementName = "plannedVisitEndTime", IsNullable = true)]
    public string PlannedVisitEndTimeField
    {
      get
      {
        return !this.PlannedVisitEndTime.HasValue ? (string) null : this.PlannedVisitEndTime.Value.ToString("hh\\:mm\\:ss", (IFormatProvider) CultureInfo.InvariantCulture);
      }
      set
      {
        this.PlannedVisitEndTime = value == null ? new TimeSpan?() : new TimeSpan?(TimeSpan.ParseExact(value, "hh\\:mm\\:ss", (IFormatProvider) CultureInfo.InvariantCulture));
      }
    }

    [XmlElement(DataType = "date", ElementName = "plannedVisitEndDate", IsNullable = true)]
    public DateTime? PlannedVisitEndDate { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "recurrentVisitor", IsNullable = true)]
    public bool? RecurrentVisitor { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "badgeGivenToCaretaker", IsNullable = true)]
    public bool? BadgeGivenToCaretaker { get; set; }

    [XmlElement(DataType = "date", ElementName = "plannedVisitStartDate", IsNullable = true)]
    public DateTime? PlannedVisitStartDate { get; set; }

    [XmlElement(DataType = "string", ElementName = "attendanceSite", IsNullable = true)]
    public string AttendanceSite { get; set; }

    [XmlElement(DataType = "date", ElementName = "completedVisitEndDate", IsNullable = true)]
    public DateTime? CompletedVisitEndDate { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "badgeGivenToVisitor", IsNullable = true)]
    public bool? BadgeGivenToVisitor { get; set; }

    [XmlElement(DataType = "int", ElementName = "visitKey", IsNullable = true)]
    public int? VisitKey { get; set; }

    [XmlElement(DataType = "int", ElementName = "visitorKey", IsNullable = true)]
    public int? VisitorKey { get; set; }

    [XmlElement(DataType = "int", ElementName = "hostKey", IsNullable = true)]
    public int? HostKey { get; set; }

    [XmlElement(DataType = "string", ElementName = "hostSurname", IsNullable = true)]
    public string HostSurname { get; set; }

    [XmlElement(DataType = "string", ElementName = "hostFirstName", IsNullable = true)]
    public string HostFirstName { get; set; }
  }
}
