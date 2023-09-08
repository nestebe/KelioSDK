
//.ImportEmployeePredefinedFieldAssignments




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importEmployeePredefinedFieldAssignments")]
  public class ImportEmployeePredefinedFieldAssignments
  {
    [XmlArray(ElementName = "employeePredefinedFieldAssignmentsToImport", IsNullable = false, Order = 0)]
    public List<EmployeeFieldAssignment> EmployeePredefinedFieldAssignmentsToImport { get; set; }
  }
}
