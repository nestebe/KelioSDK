
//.ExportEmployeeHourlyRateAssignmentsResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportEmployeeHourlyRateAssignmentsResponse")]
  public class ExportEmployeeHourlyRateAssignmentsResponse
  {
    [XmlArray(ElementName = "exportedEmployeeHourlyRateAssignments", IsNullable = false, Order = 0)]
    public List<EmployeeHourlyRateAssignment> ExportedEmployeeHourlyRateAssignments { get; set; }
  }
}
