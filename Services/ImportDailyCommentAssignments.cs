
//.ImportDailyCommentAssignments




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importDailyCommentAssignments")]
  public class ImportDailyCommentAssignments
  {
    [XmlArray(ElementName = "dailyCommentAssignmentsToImport", IsNullable = false, Order = 0)]
    public List<DailyCommentAssignments> DailyCommentAssignmentsToImport { get; set; }
  }
}
