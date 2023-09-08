
// Type: KelioSDK.Models.AskedAnomaly




using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "AskedAnomaly")]
  public class AskedAnomaly : AskedPopulationWithPeriod
  {
    [XmlElement(DataType = "int", ElementName = "anomalyType", IsNullable = true)]
    public int? AnomalyType { get; set; }
  }
}
