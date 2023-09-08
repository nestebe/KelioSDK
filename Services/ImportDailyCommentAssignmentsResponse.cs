
//.ImportDailyCommentAssignmentsResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importDailyCommentAssignmentsResponse")]
  public class ImportDailyCommentAssignmentsResponse
  {
    [XmlArray(ElementName = "dailyCommentAssignmentsInError", IsNullable = false, Order = 0)]
    public List<DailyCommentAssignments> DailyCommentAssignmentsInError { get; set; }
  }
}
