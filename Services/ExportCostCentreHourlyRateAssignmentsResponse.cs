
//.ExportCostCentreHourlyRateAssignmentsResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportCostCentreHourlyRateAssignmentsResponse")]
  public class ExportCostCentreHourlyRateAssignmentsResponse
  {
    [XmlArray(ElementName = "exportedCostCentreHourlyRateAssignments", IsNullable = false, Order = 0)]
    public List<JobHourlyRateAssignment> ExportedCostCentreHourlyRateAssignments { get; set; }
  }
}
