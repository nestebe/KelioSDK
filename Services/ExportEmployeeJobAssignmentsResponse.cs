
//.ExportEmployeeJobAssignmentsResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportEmployeeJobAssignmentsResponse")]
  public class ExportEmployeeJobAssignmentsResponse
  {
    [XmlArray(ElementName = "exportedEmployeeJobAssignments", IsNullable = false, Order = 0)]
    public List<EmployeeJobAssignment> ExportedEmployeeJobAssignments { get; set; }
  }
}
