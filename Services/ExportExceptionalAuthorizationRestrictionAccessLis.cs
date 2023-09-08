
//.ExportExceptionalAuthorizationRestrictionAccessList




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportExceptionalAuthorizationRestrictionAccessList")]
  public class ExportExceptionalAuthorizationRestrictionAccessList
  {
    [XmlArray(ElementName = "exportFilter", IsNullable = false, Order = 0)]
    public List<AskedExceptionalAuthorizationRestrictionAccess> ExportFilter { get; set; }
  }
}
