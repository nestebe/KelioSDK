
// Type: KelioSDK.Models.DailyCommentAssignments




using System;
using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "DailyCommentAssignments")]
  public class DailyCommentAssignments : EmployeeInformation
  {
    [XmlElement(DataType = "short", ElementName = "commentType", IsNullable = true)]
    public short? CommentType { get; set; }

    [XmlElement(DataType = "date", ElementName = "assignmentDate", IsNullable = true)]
    public DateTime? AssignmentDate { get; set; }

    [XmlElement(DataType = "string", ElementName = "commentValue", IsNullable = true)]
    public string CommentValue { get; set; }
  }
}
