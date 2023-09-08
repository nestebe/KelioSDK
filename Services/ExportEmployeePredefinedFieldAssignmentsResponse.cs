
//.ExportEmployeePredefinedFieldAssignmentsResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportEmployeePredefinedFieldAssignmentsResponse")]
  public class ExportEmployeePredefinedFieldAssignmentsResponse
  {
    [XmlArray(ElementName = "exportedEmployeePredefinedFieldAssignments", IsNullable = false, Order = 0)]
    public List<EmployeeFieldAssignment> ExportedEmployeePredefinedFieldAssignments { get; set; }
  }
}
