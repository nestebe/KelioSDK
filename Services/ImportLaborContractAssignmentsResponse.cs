
//.ImportLaborContractAssignmentsResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importLaborContractAssignmentsResponse")]
  public class ImportLaborContractAssignmentsResponse
  {
    [XmlArray(ElementName = "laborContractAssignmentsInError", IsNullable = false, Order = 0)]
    public List<LaborContractAssignment> LaborContractAssignmentsInError { get; set; }
  }
}
