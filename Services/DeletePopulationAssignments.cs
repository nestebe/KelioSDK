
//.DeletePopulationAssignments




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "deletePopulationAssignments")]
  public class DeletePopulationAssignments
  {
    [XmlArray(ElementName = "populationAssignmentsToDelete", IsNullable = false, Order = 0)]
    public List<PopulationAssignment> PopulationAssignmentsToDelete { get; set; }
  }
}
