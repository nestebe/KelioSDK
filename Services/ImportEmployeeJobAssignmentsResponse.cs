
//.ImportEmployeeJobAssignmentsResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importEmployeeJobAssignmentsResponse")]
  public class ImportEmployeeJobAssignmentsResponse
  {
    [XmlArray(ElementName = "employeeJobAssignmentsInError", IsNullable = false, Order = 0)]
    public List<EmployeeJobAssignment> EmployeeJobAssignmentsInError { get; set; }
  }
}
