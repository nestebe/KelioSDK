
//.ExportEmployeeJobAssignmentsListResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportEmployeeJobAssignmentsListResponse")]
  public class ExportEmployeeJobAssignmentsListResponse
  {
    [XmlArray(ElementName = "exportedEmployeeJobAssignments", IsNullable = false, Order = 0)]
    public List<EmployeeJobAssignment> ExportedEmployeeJobAssignments { get; set; }
  }
}
