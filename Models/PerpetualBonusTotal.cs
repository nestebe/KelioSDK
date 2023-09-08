
// Type: KelioSDK.Models.PerpetualBonusTotal




using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "PerpetualBonusTotal")]
  public class PerpetualBonusTotal : AbstractPerpetualTotal
  {
    [XmlElement(DataType = "double", ElementName = "number", IsNullable = true)]
    public double? Number { get; set; }
  }
}
