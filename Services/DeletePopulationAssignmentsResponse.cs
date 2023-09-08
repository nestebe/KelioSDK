
//.DeletePopulationAssignmentsResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "deletePopulationAssignmentsResponse")]
  public class DeletePopulationAssignmentsResponse
  {
    [XmlArray(ElementName = "populationAssignmentsInError", IsNullable = false, Order = 0)]
    public List<PopulationAssignment> PopulationAssignmentsInError { get; set; }
  }
}
