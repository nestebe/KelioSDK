
//.DeleteLightEmployees




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "deleteLightEmployees")]
  public class DeleteLightEmployees
  {
    [XmlArray(ElementName = "lightEmployeesToDelete", IsNullable = false, Order = 0)]
    public List<LightEmployee> LightEmployeesToDelete { get; set; }
  }
}
