
//.ExportPopulationResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportPopulationResponse")]
  public class ExportPopulationResponse
  {
    [XmlArray(ElementName = "exportedPopulation", IsNullable = false, Order = 0)]
    public List<Population> ExportedPopulation { get; set; }
  }
}
