
// Type: KelioSDK.Models.PreliminaryPlanningAction




using KelioSDK.Common;
using System;
using System.Globalization;
using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "PreliminaryPlanningAction")]
  public class PreliminaryPlanningAction : ObjectBase
  {
    [XmlElement(DataType = "string", ElementName = "action", IsNullable = true)]
    public string Action { get; set; }

    [XmlElement(DataType = "string", ElementName = "comment", IsNullable = true)]
    public string Comment { get; set; }

    [XmlElement(DataType = "string", ElementName = "user", IsNullable = true)]
    public string User { get; set; }

    [XmlElement(DataType = "date", ElementName = "actionDate", IsNullable = true)]
    public DateTime? ActionDate { get; set; }

    [XmlElement(DataType = "string", ElementName = "populationDescription", IsNullable = true)]
    public string PopulationDescription { get; set; }

    [XmlElement(DataType = "date", ElementName = "preliminaryPlanningStartDate", IsNullable = true)]
    public DateTime? PreliminaryPlanningStartDate { get; set; }

    [XmlElement(DataType = "date", ElementName = "preliminaryPlanningEndDate", IsNullable = true)]
    public DateTime? PreliminaryPlanningEndDate { get; set; }

    [XmlElement(DataType = "string", ElementName = "preliminaryPlanningDescription", IsNullable = true)]
    public string PreliminaryPlanningDescription { get; set; }

    [XmlElement(DataType = "int", ElementName = "preliminaryPlanningKey", IsNullable = true)]
    public int? PreliminaryPlanningKey { get; set; }

    [XmlElement(DataType = "int", ElementName = "populationKey", IsNullable = true)]
    public int? PopulationKey { get; set; }

    [XmlIgnore]
    public TimeSpan? ActionTime { get; set; }

    [XmlElement(DataType = "string", ElementName = "actionTime", IsNullable = true)]
    public string ActionTimeField
    {
      get
      {
        return !this.ActionTime.HasValue ? (string) null : this.ActionTime.Value.ToString("hh\\:mm\\:ss", (IFormatProvider) CultureInfo.InvariantCulture);
      }
      set
      {
        this.ActionTime = value == null ? new TimeSpan?() : new TimeSpan?(TimeSpan.ParseExact(value, "hh\\:mm\\:ss", (IFormatProvider) CultureInfo.InvariantCulture));
      }
    }
  }
}
