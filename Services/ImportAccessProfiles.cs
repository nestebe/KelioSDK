
//.ImportAccessProfiles




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importAccessProfiles")]
  public class ImportAccessProfiles
  {
    [XmlArray(ElementName = "accessProfilesToImport", IsNullable = false, Order = 0)]
    public List<AccessProfile> AccessProfilesToImport { get; set; }
  }
}
