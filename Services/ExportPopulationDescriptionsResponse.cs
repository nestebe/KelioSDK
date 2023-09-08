
//.ExportPopulationDescriptionsResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportPopulationDescriptionsResponse")]
  public class ExportPopulationDescriptionsResponse
  {
    [XmlArray(ElementName = "exportedPopulationDescriptions", IsNullable = false, Order = 0)]
    public List<EmployeePopulation> ExportedPopulationDescriptions { get; set; }
  }
}
