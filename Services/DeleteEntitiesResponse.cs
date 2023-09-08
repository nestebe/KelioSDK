
//.DeleteEntitiesResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "deleteEntitiesResponse")]
  public class DeleteEntitiesResponse
  {
    [XmlArray(ElementName = "entitiesInError", IsNullable = false, Order = 0)]
    public List<Entity> EntitiesInError { get; set; }
  }
}
