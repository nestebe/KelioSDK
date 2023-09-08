
//.ImportLaborContractAssignments




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importLaborContractAssignments")]
  public class ImportLaborContractAssignments
  {
    [XmlArray(ElementName = "laborContractAssignmentsToImport", IsNullable = false, Order = 0)]
    public List<LaborContractAssignment> LaborContractAssignmentsToImport { get; set; }
  }
}
