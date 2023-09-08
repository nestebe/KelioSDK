
//.DeleteCostCenterFiling




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "deleteCostCenterFiling")]
  public class DeleteCostCenterFiling
  {
    [XmlArray(ElementName = "costCenterFilingToDelete", IsNullable = false, Order = 0)]
    public List<Filing> CostCenterFilingToDelete { get; set; }
  }
}
