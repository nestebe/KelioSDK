
//.DeleteExceptionalAuthorizationRestrictionAccess




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "deleteExceptionalAuthorizationRestrictionAccess")]
  public class DeleteExceptionalAuthorizationRestrictionAccess
  {
    [XmlArray(ElementName = "exceptionalAuthorizationRestrictionAccessToDelete", IsNullable = false, Order = 0)]
    public List<ExceptionalAuthorizationRestrictionAccess> ExceptionalAuthorizationRestrictionAccessToDelete { get; set; }
  }
}
