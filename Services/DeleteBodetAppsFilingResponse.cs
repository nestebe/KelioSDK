
//.DeleteBodetAppsFilingResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "deleteBodetAppsFilingResponse")]
  public class DeleteBodetAppsFilingResponse
  {
    [XmlArray(ElementName = "bodetAppsFilingInError", IsNullable = false, Order = 0)]
    public List<Filing> BodetAppsFilingInError { get; set; }
  }
}
