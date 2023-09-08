
// Type: KelioSDK.Models.CompensatoryLeaveLimit




using KelioSDK.Common;
using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "CompensatoryLeaveLimit")]
  public class CompensatoryLeaveLimit : ObjectBase
  {
    [XmlElement(DataType = "double", ElementName = "notExceededAnnualisedOvertimeLimitValue", IsNullable = true)]
    public double? NotExceededAnnualisedOvertimeLimitValue { get; set; }

    [XmlElement(DataType = "double", ElementName = "annualisedWeekOvertimeLimitValue", IsNullable = true)]
    public double? AnnualisedWeekOvertimeLimitValue { get; set; }

    [XmlElement(DataType = "int", ElementName = "compensatoryLeaveLimitKey", IsNullable = true)]
    public int? CompensatoryLeaveLimitKey { get; set; }

    [XmlElement(DataType = "double", ElementName = "exceededAnnualisedOvertimeLimitValue", IsNullable = true)]
    public double? ExceededAnnualisedOvertimeLimitValue { get; set; }

    [XmlElement(DataType = "string", ElementName = "scheduleAbbreviation", IsNullable = true)]
    public string ScheduleAbbreviation { get; set; }

    [XmlElement(DataType = "string", ElementName = "scheduleDescription", IsNullable = true)]
    public string ScheduleDescription { get; set; }

    [XmlElement(DataType = "int", ElementName = "weekRank", IsNullable = true)]
    public int? WeekRank { get; set; }
  }
}
