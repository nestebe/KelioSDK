
//.ExportLightEmployeesList




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportLightEmployeesList")]
  public class ExportLightEmployeesList
  {
    [XmlArray(ElementName = "exportFilter", IsNullable = false, Order = 0)]
    public List<AskedPopulation> ExportFilter { get; set; }
  }
}
