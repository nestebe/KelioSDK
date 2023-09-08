
// Type: KelioSDK.Models.Interface




using KelioSDK.Common;
using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "Interface")]
  public class Interface : ObjectBase
  {
    [XmlElement(DataType = "int", ElementName = "modelType", IsNullable = true)]
    public int? ModelType { get; set; }

    [XmlElement(DataType = "string", ElementName = "source", IsNullable = true)]
    public string Source { get; set; }

    [XmlElement(DataType = "string", ElementName = "compatibleVersion", IsNullable = true)]
    public string CompatibleVersion { get; set; }

    [XmlElement(DataType = "string", ElementName = "technology", IsNullable = true)]
    public string Technology { get; set; }

    [XmlElement(DataType = "string", ElementName = "engineVersion", IsNullable = true)]
    public string EngineVersion { get; set; }

    [XmlElement(DataType = "string", ElementName = "instanceDescription", IsNullable = true)]
    public string InstanceDescription { get; set; }

    [XmlElement(DataType = "string", ElementName = "modelId", IsNullable = true)]
    public string ModelId { get; set; }

    [XmlElement(DataType = "string", ElementName = "modelDescription", IsNullable = true)]
    public string ModelDescription { get; set; }

    [XmlElement(DataType = "int", ElementName = "modelKey", IsNullable = true)]
    public int? ModelKey { get; set; }

    [XmlElement(DataType = "string", ElementName = "modelVersion", IsNullable = true)]
    public string ModelVersion { get; set; }

    [XmlElement(DataType = "int", ElementName = "instanceKey", IsNullable = true)]
    public int? InstanceKey { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "standard", IsNullable = true)]
    public bool? Standard { get; set; }
  }
}
