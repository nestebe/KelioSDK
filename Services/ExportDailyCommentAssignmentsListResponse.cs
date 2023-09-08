
//.ExportDailyCommentAssignmentsListResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportDailyCommentAssignmentsListResponse")]
  public class ExportDailyCommentAssignmentsListResponse
  {
    [XmlArray(ElementName = "exportedDailyCommentAssignments", IsNullable = false, Order = 0)]
    public List<DailyCommentAssignments> ExportedDailyCommentAssignments { get; set; }
  }
}
