
//.ImportLightEmployeesResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importLightEmployeesResponse")]
  public class ImportLightEmployeesResponse
  {
    [XmlArray(ElementName = "lightEmployeesInError", IsNullable = false, Order = 0)]
    public List<LightEmployee> LightEmployeesInError { get; set; }
  }
}
