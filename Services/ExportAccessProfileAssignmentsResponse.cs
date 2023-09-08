
//.ExportAccessProfileAssignmentsResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportAccessProfileAssignmentsResponse")]
  public class ExportAccessProfileAssignmentsResponse
  {
    [XmlArray(ElementName = "exportedAccessProfileAssignments", IsNullable = false, Order = 0)]
    public List<AccessProfileAssignment> ExportedAccessProfileAssignments { get; set; }
  }
}
