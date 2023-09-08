
//.DeleteDailyCommentAssignments




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "deleteDailyCommentAssignments")]
  public class DeleteDailyCommentAssignments
  {
    [XmlArray(ElementName = "dailyCommentAssignmentsToDelete", IsNullable = false, Order = 0)]
    public List<DailyCommentAssignments> DailyCommentAssignmentsToDelete { get; set; }
  }
}
