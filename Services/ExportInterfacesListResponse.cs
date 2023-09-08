
//.ExportInterfacesListResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportInterfacesListResponse")]
  public class ExportInterfacesListResponse
  {
    [XmlArray(ElementName = "exportedInterfaces", IsNullable = false, Order = 0)]
    public List<Interface> ExportedInterfaces { get; set; }
  }
}
