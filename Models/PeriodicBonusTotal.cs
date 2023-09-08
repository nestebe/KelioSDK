
// Type: KelioSDK.Models.PeriodicBonusTotal




using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "PeriodicBonusTotal")]
  public class PeriodicBonusTotal : AbstractPeriodicTotal
  {
    [XmlElement(DataType = "double", ElementName = "number", IsNullable = true)]
    public double? Number { get; set; }
  }
}
