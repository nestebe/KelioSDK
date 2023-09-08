
// Type: KelioSDK.Models.AskedUserProfile




using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "AskedUserProfile")]
  public class AskedUserProfile
  {
    [XmlElement(DataType = "int", ElementName = "profileType", IsNullable = true)]
    public int? ProfileType { get; set; }

    [XmlElement(DataType = "string", ElementName = "userLogin", IsNullable = true)]
    public string UserLogin { get; set; }
  }
}
