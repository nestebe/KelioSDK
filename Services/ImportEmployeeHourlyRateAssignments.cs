
//.ImportEmployeeHourlyRateAssignments




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importEmployeeHourlyRateAssignments")]
  public class ImportEmployeeHourlyRateAssignments
  {
    [XmlArray(ElementName = "employeeHourlyRateAssignmentsToImport", IsNullable = false, Order = 0)]
    public List<EmployeeHourlyRateAssignment> EmployeeHourlyRateAssignmentsToImport { get; set; }
  }
}
