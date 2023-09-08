
// Type: KelioSDK.Models.HourToHourRequirement




using KelioSDK.Common;
using System;
using System.Globalization;
using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "HourToHourRequirement")]
  public class HourToHourRequirement : ObjectBase
  {
    [XmlElement(DataType = "date", ElementName = "applicationDate", IsNullable = true)]
    public DateTime? ApplicationDate { get; set; }

    [XmlElement(DataType = "double", ElementName = "number", IsNullable = true)]
    public double? Number { get; set; }

    [XmlIgnore]
    public TimeSpan? StartTime { get; set; }

    [XmlElement(DataType = "string", ElementName = "startTime", IsNullable = true)]
    public string StartTimeField
    {
      get
      {
        return !this.StartTime.HasValue ? (string) null : this.StartTime.Value.ToString("hh\\:mm\\:ss", (IFormatProvider) CultureInfo.InvariantCulture);
      }
      set
      {
        this.StartTime = value == null ? new TimeSpan?() : new TimeSpan?(TimeSpan.ParseExact(value, "hh\\:mm\\:ss", (IFormatProvider) CultureInfo.InvariantCulture));
      }
    }

    [XmlIgnore]
    public TimeSpan? EndTime { get; set; }

    [XmlElement(DataType = "string", ElementName = "endTime", IsNullable = true)]
    public string EndTimeField
    {
      get
      {
        return !this.EndTime.HasValue ? (string) null : this.EndTime.Value.ToString("hh\\:mm\\:ss", (IFormatProvider) CultureInfo.InvariantCulture);
      }
      set
      {
        this.EndTime = value == null ? new TimeSpan?() : new TimeSpan?(TimeSpan.ParseExact(value, "hh\\:mm\\:ss", (IFormatProvider) CultureInfo.InvariantCulture));
      }
    }

    [XmlElement(DataType = "boolean", ElementName = "blockingRequirement", IsNullable = true)]
    public bool? BlockingRequirement { get; set; }

    [XmlElement(DataType = "double", ElementName = "hours", IsNullable = true)]
    public double? Hours { get; set; }

    [XmlElement(DataType = "string", ElementName = "postInColumnDescription", IsNullable = true)]
    public string PostInColumnDescription { get; set; }

    [XmlElement(DataType = "int", ElementName = "postKey", IsNullable = true)]
    public int? PostKey { get; set; }

    [XmlElement(DataType = "string", ElementName = "postDescription", IsNullable = true)]
    public string PostDescription { get; set; }

    [XmlElement(DataType = "int", ElementName = "postInColumnKey", IsNullable = true)]
    public int? PostInColumnKey { get; set; }

    [XmlElement(DataType = "string", ElementName = "populationDescription", IsNullable = true)]
    public string PopulationDescription { get; set; }

    [XmlElement(DataType = "int", ElementName = "populationKey", IsNullable = true)]
    public int? PopulationKey { get; set; }

    [XmlElement(DataType = "int", ElementName = "requirementKey", IsNullable = true)]
    public int? RequirementKey { get; set; }
  }
}
