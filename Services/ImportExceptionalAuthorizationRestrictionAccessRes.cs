
//.ImportExceptionalAuthorizationRestrictionAccessResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importExceptionalAuthorizationRestrictionAccessResponse")]
  public class ImportExceptionalAuthorizationRestrictionAccessResponse
  {
    [XmlArray(ElementName = "exceptionalAuthorizationRestrictionAccessInError", IsNullable = false, Order = 0)]
    public List<ExceptionalAuthorizationRestrictionAccess> ExceptionalAuthorizationRestrictionAccessInError { get; set; }
  }
}
