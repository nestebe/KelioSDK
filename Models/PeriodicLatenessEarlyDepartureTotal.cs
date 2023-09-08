
// Type: KelioSDK.Models.PeriodicLatenessEarlyDepartureTotal




using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "PeriodicLatenessEarlyDepartureTotal")]
  public class PeriodicLatenessEarlyDepartureTotal : AbstractPeriodicTotal
  {
    [XmlElement(DataType = "double", ElementName = "number", IsNullable = true)]
    public double? Number { get; set; }

    [XmlElement(DataType = "double", ElementName = "hours", IsNullable = true)]
    public double? Hours { get; set; }
  }
}
