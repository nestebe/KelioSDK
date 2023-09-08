
//.ImportUserProfileAssignmentsResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importUserProfileAssignmentsResponse")]
  public class ImportUserProfileAssignmentsResponse
  {
    [XmlArray(ElementName = "userProfileAssignmentsInError", IsNullable = false, Order = 0)]
    public List<UserProfileAssignment> UserProfileAssignmentsInError { get; set; }
  }
}
