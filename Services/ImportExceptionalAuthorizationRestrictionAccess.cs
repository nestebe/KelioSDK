
//.ImportExceptionalAuthorizationRestrictionAccess




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importExceptionalAuthorizationRestrictionAccess")]
  public class ImportExceptionalAuthorizationRestrictionAccess
  {
    [XmlArray(ElementName = "exceptionalAuthorizationRestrictionAccessToImport", IsNullable = false, Order = 0)]
    public List<ExceptionalAuthorizationRestrictionAccess> ExceptionalAuthorizationRestrictionAccessToImport { get; set; }
  }
}
