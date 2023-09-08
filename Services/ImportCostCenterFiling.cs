
//.ImportCostCenterFiling




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importCostCenterFiling")]
  public class ImportCostCenterFiling
  {
    [XmlArray(ElementName = "costCenterFilingToImport", IsNullable = false, Order = 0)]
    public List<Filing> CostCenterFilingToImport { get; set; }
  }
}
