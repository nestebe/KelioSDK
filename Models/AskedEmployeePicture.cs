
// Type: KelioSDK.Models.AskedEmployeePicture




using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "AskedEmployeePicture")]
  public class AskedEmployeePicture : AskedPopulation
  {
    [XmlElement(DataType = "string", ElementName = "directoryName", IsNullable = true)]
    public string DirectoryName { get; set; }
  }
}
