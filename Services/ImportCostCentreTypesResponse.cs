
//.ImportCostCentreTypesResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importCostCentreTypesResponse")]
  public class ImportCostCentreTypesResponse
  {
    [XmlArray(ElementName = "CostCentreTypesInError", IsNullable = false, Order = 0)]
    public List<CostCentreType> CostCentreTypesInError { get; set; }
  }
}
