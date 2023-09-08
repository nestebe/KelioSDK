
//.ExportEntitiesResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportEntitiesResponse")]
  public class ExportEntitiesResponse
  {
    [XmlArray(ElementName = "exportedEntities", IsNullable = false, Order = 0)]
    public List<Entity> ExportedEntities { get; set; }
  }
}
