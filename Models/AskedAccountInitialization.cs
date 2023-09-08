
// Type: KelioSDK.Models.AskedAccountInitialization




using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "AskedAccountInitialization")]
  public class AskedAccountInitialization : AskedPopulationWithPeriod
  {
    [XmlElement(DataType = "short", ElementName = "initializationType", IsNullable = true)]
    public short? InitializationType { get; set; }
  }
}
