
// Type: KelioSDK.Models.SpecificInterfaceParameterFilter




using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "SpecificInterfaceParameterFilter")]
  public class SpecificInterfaceParameterFilter : AskedPopulationWithPeriod
  {
    [XmlElement(DataType = "string", ElementName = "instanceDescription", IsNullable = true)]
    public string InstanceDescription { get; set; }
  }
}
