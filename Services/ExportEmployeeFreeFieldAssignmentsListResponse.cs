
//.ExportEmployeeFreeFieldAssignmentsListResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportEmployeeFreeFieldAssignmentsListResponse")]
  public class ExportEmployeeFreeFieldAssignmentsListResponse
  {
    [XmlArray(ElementName = "exportedEmployeeFreeFieldAssignments", IsNullable = false, Order = 0)]
    public List<EmployeeFieldAssignment> ExportedEmployeeFreeFieldAssignments { get; set; }
  }
}
