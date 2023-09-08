
//.ExportPreliminaryPlanningActionsServiceResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportPreliminaryPlanningActionsServiceResponse")]
  public class ExportPreliminaryPlanningActionsServiceResponse
  {
    [XmlArray(ElementName = "exportedPreliminaryPlanningActionsService", IsNullable = false, Order = 0)]
    public List<PreliminaryPlanningAction> ExportedPreliminaryPlanningActionsService { get; set; }
  }
}
