
//.ExportCostCenterFilingResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportCostCenterFilingResponse")]
  public class ExportCostCenterFilingResponse
  {
    [XmlArray(ElementName = "exportedCostCenterFiling", IsNullable = false, Order = 0)]
    public List<Filing> ExportedCostCenterFiling { get; set; }
  }
}
