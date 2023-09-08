
// Type: KelioSDK.Models.WeeklyBonusTotal




using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "WeeklyBonusTotal")]
  public class WeeklyBonusTotal : AbstractWeeklyTotal
  {
    [XmlElement(DataType = "double", ElementName = "number", IsNullable = true)]
    public double? Number { get; set; }
  }
}
