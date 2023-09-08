
// Type: KelioSDK.Models.ExceptionalAuthorizationRestrictionAccess




using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "ExceptionalAuthorizationRestrictionAccess")]
  public class ExceptionalAuthorizationRestrictionAccess : AccessAuthorization
  {
    [XmlElement(DataType = "boolean", ElementName = "authorizedAccess", IsNullable = true)]
    public bool? AuthorizedAccess { get; set; }
  }
}
