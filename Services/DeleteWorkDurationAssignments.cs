
//.DeleteWorkDurationAssignments




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "deleteWorkDurationAssignments")]
  public class DeleteWorkDurationAssignments
  {
    [XmlArray(ElementName = "workDurationAssignmentsToDelete", IsNullable = false, Order = 0)]
    public List<WorkDurationAssignments> WorkDurationAssignmentsToDelete { get; set; }
  }
}
