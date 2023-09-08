
// Type: KelioSDK.Models.WeeklyOvertimeHourTotal




using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "WeeklyOvertimeHourTotal")]
  public class WeeklyOvertimeHourTotal : AbstractWeeklyTotal
  {
    [XmlElement(DataType = "double", ElementName = "hours", IsNullable = true)]
    public double? Hours { get; set; }
  }
}
