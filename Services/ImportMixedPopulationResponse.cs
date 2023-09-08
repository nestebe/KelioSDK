
//.ImportMixedPopulationResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importMixedPopulationResponse")]
  public class ImportMixedPopulationResponse
  {
    [XmlArray(ElementName = "mixedPopulationsInError", IsNullable = false, Order = 0)]
    public List<EmployeePopulation> MixedPopulationsInError { get; set; }
  }
}
