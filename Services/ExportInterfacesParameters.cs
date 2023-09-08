
//.ExportInterfacesParameters




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportInterfacesParameters")]
  public class ExportInterfacesParameters
  {
    [XmlArray(ElementName = "exportFilter", IsNullable = false, Order = 0)]
    public List<AskedInterfaceInstance> ExportFilter { get; set; }
  }
}
