
//.ImportEmployeeFreeFieldAssignments




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importEmployeeFreeFieldAssignments")]
  public class ImportEmployeeFreeFieldAssignments
  {
    [XmlArray(ElementName = "employeeFreeFieldAssignmentsToImport", IsNullable = false, Order = 0)]
    public List<EmployeeFieldAssignment> EmployeeFreeFieldAssignmentsToImport { get; set; }
  }
}
