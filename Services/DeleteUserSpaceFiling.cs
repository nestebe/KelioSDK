
//.DeleteUserSpaceFiling




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "deleteUserSpaceFiling")]
  public class DeleteUserSpaceFiling
  {
    [XmlArray(ElementName = "userSpaceFilingToDelete", IsNullable = false, Order = 0)]
    public List<Filing> UserSpaceFilingToDelete { get; set; }
  }
}
