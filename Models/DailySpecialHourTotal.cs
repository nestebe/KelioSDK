
// Type: KelioSDK.Models.DailySpecialHourTotal




using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "DailySpecialHourTotal")]
  public class DailySpecialHourTotal : AbstractDailyTotal
  {
    [XmlElement(DataType = "double", ElementName = "hours", IsNullable = true)]
    public double? Hours { get; set; }
  }
}
