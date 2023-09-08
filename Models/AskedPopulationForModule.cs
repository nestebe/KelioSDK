
// Type: KelioSDK.Models.AskedPopulationForModule




using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "AskedPopulationForModule")]
  public class AskedPopulationForModule : AskedPopulation
  {
    [XmlElement(DataType = "boolean", ElementName = "includeTandAModuleEmployees", IsNullable = true)]
    public bool? IncludeTandAModuleEmployees { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "includeAccessModuleEmployees", IsNullable = true)]
    public bool? IncludeAccessModuleEmployees { get; set; }
  }
}
