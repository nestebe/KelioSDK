
//.ExportComputedJobAssignmentsListResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportComputedJobAssignmentsListResponse")]
  public class ExportComputedJobAssignmentsListResponse
  {
    [XmlArray(ElementName = "exportedComputedJobAssignments", IsNullable = false, Order = 0)]
    public List<ComputedJobAssignment> ExportedComputedJobAssignments { get; set; }
  }
}
