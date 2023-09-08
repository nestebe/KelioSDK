
//.ImportEmployeePredefinedFieldAssignmentsResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importEmployeePredefinedFieldAssignmentsResponse")]
  public class ImportEmployeePredefinedFieldAssignmentsResponse
  {
    [XmlArray(ElementName = "employeePredefinedFieldAssignmentsInError", IsNullable = false, Order = 0)]
    public List<EmployeeFieldAssignment> EmployeePredefinedFieldAssignmentsInError { get; set; }
  }
}
