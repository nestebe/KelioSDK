
//.ExportLightEmployeesResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportLightEmployeesResponse")]
  public class ExportLightEmployeesResponse
  {
    [XmlArray(ElementName = "exportedLightEmployees", IsNullable = false, Order = 0)]
    public List<LightEmployee> ExportedLightEmployees { get; set; }
  }
}
