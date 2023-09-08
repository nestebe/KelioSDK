
// Type: KelioSDK.Models.AskedDailyCommentAssignments




using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "AskedDailyCommentAssignments")]
  public class AskedDailyCommentAssignments : AskedPopulationWithPeriod
  {
    [XmlElement(DataType = "short", ElementName = "commentType", IsNullable = true)]
    public short? CommentType { get; set; }
  }
}
