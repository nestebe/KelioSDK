
//.ImportEmployeeFreeFieldAssignmentsResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importEmployeeFreeFieldAssignmentsResponse")]
  public class ImportEmployeeFreeFieldAssignmentsResponse
  {
    [XmlArray(ElementName = "employeeFreeFieldAssignmentsInError", IsNullable = false, Order = 0)]
    public List<EmployeeFieldAssignment> EmployeeFreeFieldAssignmentsInError { get; set; }
  }
}
