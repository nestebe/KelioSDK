
//.ImportEntities




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importEntities")]
  public class ImportEntities
  {
    [XmlArray(ElementName = "entitiesToImport", IsNullable = false, Order = 0)]
    public List<Entity> EntitiesToImport { get; set; }
  }
}
