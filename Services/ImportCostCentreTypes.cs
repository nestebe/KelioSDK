
//.ImportCostCentreTypes




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importCostCentreTypes")]
  public class ImportCostCentreTypes
  {
    [XmlArray(ElementName = "CostCentreTypesToImport", IsNullable = false, Order = 0)]
    public List<CostCentreType> CostCentreTypesToImport { get; set; }
  }
}
