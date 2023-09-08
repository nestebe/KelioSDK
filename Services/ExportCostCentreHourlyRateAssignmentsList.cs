
//.ExportCostCentreHourlyRateAssignmentsList




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportCostCentreHourlyRateAssignmentsList")]
  public class ExportCostCentreHourlyRateAssignmentsList
  {
    [XmlArray(ElementName = "exportFilter", IsNullable = false, Order = 0)]
    public List<AskedCostCentreHourlyRateAssignment> ExportFilter { get; set; }
  }
}
