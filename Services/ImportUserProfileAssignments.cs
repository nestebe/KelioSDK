
//.ImportUserProfileAssignments




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importUserProfileAssignments")]
  public class ImportUserProfileAssignments
  {
    [XmlArray(ElementName = "userProfileAssignmentsToImport", IsNullable = false, Order = 0)]
    public List<UserProfileAssignment> UserProfileAssignmentsToImport { get; set; }
  }
}
