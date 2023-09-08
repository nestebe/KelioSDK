
//.ImportCostCenterFilingResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importCostCenterFilingResponse")]
  public class ImportCostCenterFilingResponse
  {
    [XmlArray(ElementName = "costCenterFilingInError", IsNullable = false, Order = 0)]
    public List<Filing> CostCenterFilingInError { get; set; }
  }
}
