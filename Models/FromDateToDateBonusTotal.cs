
// Type: KelioSDK.Models.FromDateToDateBonusTotal




using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "FromDateToDateBonusTotal")]
  public class FromDateToDateBonusTotal : AbstractFromDateToDateTotal
  {
    [XmlElement(DataType = "double", ElementName = "number", IsNullable = true)]
    public double? Number { get; set; }
  }
}
