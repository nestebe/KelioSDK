
//.ExportWorkDurationAssignmentsResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportWorkDurationAssignmentsResponse")]
  public class ExportWorkDurationAssignmentsResponse
  {
    [XmlArray(ElementName = "exportedWorkDurationAssignments", IsNullable = false, Order = 0)]
    public List<WorkDurationAssignments> ExportedWorkDurationAssignments { get; set; }
  }
}
