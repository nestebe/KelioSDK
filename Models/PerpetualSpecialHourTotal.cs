
// Type: KelioSDK.Models.PerpetualSpecialHourTotal




using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "PerpetualSpecialHourTotal")]
  public class PerpetualSpecialHourTotal : AbstractPerpetualTotal
  {
    [XmlElement(DataType = "double", ElementName = "hours", IsNullable = true)]
    public double? Hours { get; set; }
  }
}
