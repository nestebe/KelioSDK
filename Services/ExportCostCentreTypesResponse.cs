
//.ExportCostCentreTypesResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportCostCentreTypesResponse")]
  public class ExportCostCentreTypesResponse
  {
    [XmlArray(ElementName = "exportedCostCentreTypes", IsNullable = false, Order = 0)]
    public List<CostCentreType> ExportedCostCentreTypes { get; set; }
  }
}
