
//.ImportAccessAuthorization




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importAccessAuthorization")]
  public class ImportAccessAuthorization
  {
    [XmlArray(ElementName = "accessAuthorizationToImport", IsNullable = false, Order = 0)]
    public List<AccessAuthorization> AccessAuthorizationToImport { get; set; }
  }
}
