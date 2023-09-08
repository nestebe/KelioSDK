
// Type: KelioSDK.Models.DailyBonusTotal




using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "DailyBonusTotal")]
  public class DailyBonusTotal : AbstractDailyTotal
  {
    [XmlElement(DataType = "double", ElementName = "number", IsNullable = true)]
    public double? Number { get; set; }
  }
}
