
//.ImportEmployeeJobAssignments




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importEmployeeJobAssignments")]
  public class ImportEmployeeJobAssignments
  {
    [XmlArray(ElementName = "employeeJobAssignmentsToImport", IsNullable = false, Order = 0)]
    public List<EmployeeJobAssignment> EmployeeJobAssignmentsToImport { get; set; }
  }
}
