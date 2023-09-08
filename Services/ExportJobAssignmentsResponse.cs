
//.ExportJobAssignmentsResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportJobAssignmentsResponse")]
  public class ExportJobAssignmentsResponse
  {
    [XmlArray(ElementName = "exportedJobAssignments", IsNullable = false, Order = 0)]
    public List<JobAssignment> ExportedJobAssignments { get; set; }
  }
}
