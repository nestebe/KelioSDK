
//.DeleteUserSpaceFilingResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "deleteUserSpaceFilingResponse")]
  public class DeleteUserSpaceFilingResponse
  {
    [XmlArray(ElementName = "userSpaceFilingInError", IsNullable = false, Order = 0)]
    public List<Filing> UserSpaceFilingInError { get; set; }
  }
}
