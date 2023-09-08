
// Type: KelioSDK.Models.VisitPurpose




using KelioSDK.Common;
using System;
using System.Globalization;
using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "VisitPurpose")]
  public class VisitPurpose : ObjectBase
  {
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

    [XmlElement(DataType = "date", ElementName = "plannedVisitStartDate", IsNullable = true)]
    public DateTime? PlannedVisitStartDate { get; set; }

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

    [XmlElement(DataType = "int", ElementName = "visitFieldKey", IsNullable = true)]
    public int? VisitFieldKey { get; set; }

    [XmlElement(DataType = "int", ElementName = "visitKey", IsNullable = true)]
    public int? VisitKey { get; set; }

    [XmlElement(DataType = "date", ElementName = "plannedVisitEndDate", IsNullable = true)]
    public DateTime? PlannedVisitEndDate { get; set; }

    [XmlElement(DataType = "string", ElementName = "visitFieldValue", IsNullable = true)]
    public string VisitFieldValue { get; set; }

    [XmlElement(DataType = "string", ElementName = "visitFieldDescription", IsNullable = true)]
    public string VisitFieldDescription { get; set; }
  }
}
