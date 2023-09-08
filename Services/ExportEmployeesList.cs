
//.ExportEmployeesList




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportEmployeesList")]
  public class ExportEmployeesList
  {
    [XmlArray(ElementName = "populationFilter", IsNullable = false, Order = 0)]
    public List<AskedPopulation> PopulationFilter { get; set; }
  }
}
