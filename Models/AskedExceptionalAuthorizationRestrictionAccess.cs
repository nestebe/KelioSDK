
// Type: KelioSDK.Models.AskedExceptionalAuthorizationRestrictionAccess




using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "AskedExceptionalAuthorizationRestrictionAccess")]
  public class AskedExceptionalAuthorizationRestrictionAccess : AskedPopulationWithPeriod
  {
    [XmlElement(DataType = "boolean", ElementName = "authorizedAccess", IsNullable = true)]
    public bool? AuthorizedAccess { get; set; }
  }
}
