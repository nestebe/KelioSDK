
//.ImportCostCentreHourlyRateAssignments




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importCostCentreHourlyRateAssignments")]
  public class ImportCostCentreHourlyRateAssignments
  {
    [XmlArray(ElementName = "costCentreHourlyRateAssignmentsToImport", IsNullable = false, Order = 0)]
    public List<JobHourlyRateAssignment> CostCentreHourlyRateAssignmentsToImport { get; set; }
  }
}
