
// Type: KelioSDK.Models.AskedRequirementsWithKey




using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "AskedRequirementsWithKey")]
  public class AskedRequirementsWithKey : AskedRequirements
  {
    [XmlElement(DataType = "int", ElementName = "requirementKey", IsNullable = true)]
    public int? RequirementKey { get; set; }
  }
}
