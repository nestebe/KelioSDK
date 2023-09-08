
// Type: KelioSDK.Models.AskedInterfaceInstance




using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "AskedInterfaceInstance")]
  public class AskedInterfaceInstance
  {
    [XmlElement(DataType = "string", ElementName = "instanceDescription", IsNullable = true)]
    public string InstanceDescription { get; set; }

    [XmlElement(DataType = "string", ElementName = "userLogin", IsNullable = true)]
    public string UserLogin { get; set; }

    [XmlElement(DataType = "int", ElementName = "userKey", IsNullable = true)]
    public int? UserKey { get; set; }

    [XmlElement(DataType = "string", ElementName = "populationFilter", IsNullable = true)]
    public string PopulationFilter { get; set; }
  }
}
