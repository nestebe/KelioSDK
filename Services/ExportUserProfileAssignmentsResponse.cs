
//.ExportUserProfileAssignmentsResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportUserProfileAssignmentsResponse")]
  public class ExportUserProfileAssignmentsResponse
  {
    [XmlArray(ElementName = "exportedUserProfileAssignments", IsNullable = false, Order = 0)]
    public List<UserProfileAssignment> ExportedUserProfileAssignments { get; set; }
  }
}
