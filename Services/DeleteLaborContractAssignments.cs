
//.DeleteLaborContractAssignments




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "deleteLaborContractAssignments")]
  public class DeleteLaborContractAssignments
  {
    [XmlArray(ElementName = "laborContractAssignmentToDelete", IsNullable = false, Order = 0)]
    public List<LaborContractAssignment> LaborContractAssignmentToDelete { get; set; }
  }
}
