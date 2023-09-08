
//.ExportInterfacesParametersResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportInterfacesParametersResponse")]
  public class ExportInterfacesParametersResponse
  {
    [XmlArray(ElementName = "exportedInterfacesParameters", IsNullable = false, Order = 0)]
    public List<IntanceParameter> ExportedInterfacesParameters { get; set; }
  }
}
