
// Type: KelioSDK.Models.PeriodicSpecialHourTotal




using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "PeriodicSpecialHourTotal")]
  public class PeriodicSpecialHourTotal : AbstractPeriodicTotal
  {
    [XmlElement(DataType = "double", ElementName = "hours", IsNullable = true)]
    public double? Hours { get; set; }
  }
}
