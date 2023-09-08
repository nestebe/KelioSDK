
//.DeleteEntities




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "deleteEntities")]
  public class DeleteEntities
  {
    [XmlArray(ElementName = "entitiesToDelete", IsNullable = false, Order = 0)]
    public List<Entity> EntitiesToDelete { get; set; }
  }
}
