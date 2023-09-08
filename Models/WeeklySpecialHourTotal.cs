
// Type: KelioSDK.Models.WeeklySpecialHourTotal




using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "WeeklySpecialHourTotal")]
  public class WeeklySpecialHourTotal : AbstractWeeklyTotal
  {
    [XmlElement(DataType = "double", ElementName = "hours", IsNullable = true)]
    public double? Hours { get; set; }
  }
}
