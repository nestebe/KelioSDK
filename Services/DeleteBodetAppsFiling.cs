
//.DeleteBodetAppsFiling




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "deleteBodetAppsFiling")]
  public class DeleteBodetAppsFiling
  {
    [XmlArray(ElementName = "bodetAppsFilingToDelete", IsNullable = false, Order = 0)]
    public List<Filing> BodetAppsFilingToDelete { get; set; }
  }
}
