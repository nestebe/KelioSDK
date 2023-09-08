
//.DeleteJobAssignments




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "deleteJobAssignments")]
  public class DeleteJobAssignments
  {
    [XmlArray(ElementName = "jobAssignmentsToDelete", IsNullable = false, Order = 0)]
    public List<JobAssignment> JobAssignmentsToDelete { get; set; }
  }
}
