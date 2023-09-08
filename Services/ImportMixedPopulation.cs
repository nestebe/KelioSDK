
//.ImportMixedPopulation




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importMixedPopulation")]
  public class ImportMixedPopulation
  {
    [XmlArray(ElementName = "mixedPopulationsToImport", IsNullable = false, Order = 0)]
    public List<EmployeePopulation> MixedPopulationsToImport { get; set; }
  }
}
