
//.ExportPreliminaryPlanningActionsService




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportPreliminaryPlanningActionsService")]
  public class ExportPreliminaryPlanningActionsService
  {
    [XmlArray(ElementName = "exportFilter", IsNullable = false, Order = 0)]
    public List<PreliminaryPlanningFilter> ExportFilter { get; set; }
  }
}
