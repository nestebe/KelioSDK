
//.ImportPopulationAssignments




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importPopulationAssignments")]
  public class ImportPopulationAssignments
  {
    [XmlArray(ElementName = "populationAssignmentsToImport", IsNullable = false, Order = 0)]
    public List<PopulationAssignment> PopulationAssignmentsToImport { get; set; }
  }
}
