
//.ExportLaborContractAssignmentsResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportLaborContractAssignmentsResponse")]
  public class ExportLaborContractAssignmentsResponse
  {
    [XmlArray(ElementName = "exportedLaborContractAssignments", IsNullable = false, Order = 0)]
    public List<LaborContractAssignment> ExportedLaborContractAssignments { get; set; }
  }
}
