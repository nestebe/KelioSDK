
//.ExportAssignmentPublicHolListResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportAssignmentPublicHolListResponse")]
  public class ExportAssignmentPublicHolListResponse
  {
    [XmlArray(ElementName = "exportedAssignmentPublicHol", IsNullable = false, Order = 0)]
    public List<PublicHolAssigning> ExportedAssignmentPublicHol { get; set; }
  }
}
