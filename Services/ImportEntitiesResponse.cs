
//.ImportEntitiesResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importEntitiesResponse")]
  public class ImportEntitiesResponse
  {
    [XmlArray(ElementName = "entitiesInError", IsNullable = false, Order = 0)]
    public List<Entity> EntitiesInError { get; set; }
  }
}
