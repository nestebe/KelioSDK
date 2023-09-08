
//.DeleteDailyCommentAssignmentsResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "deleteDailyCommentAssignmentsResponse")]
  public class DeleteDailyCommentAssignmentsResponse
  {
    [XmlArray(ElementName = "dailyCommentAssignmentsInError", IsNullable = false, Order = 0)]
    public List<DailyCommentAssignments> DailyCommentAssignmentsInError { get; set; }
  }
}
