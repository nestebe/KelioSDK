
//.ExportUserProfileAssignments




using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportUserProfileAssignments")]
  public class ExportUserProfileAssignments
  {
    [XmlElement(DataType = "string", ElementName = "userLogin", IsNullable = true, Order = 0)]
    public string UserLogin { get; set; }

    [XmlElement(DataType = "string", ElementName = "profileType", IsNullable = true, Order = 1)]
    public string ProfileType { get; set; }
  }
}
