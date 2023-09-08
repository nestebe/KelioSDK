
// Type: KelioSDK.Models.PostJobAndSkillAssignmentFilter




using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "PostJobAndSkillAssignmentFilter")]
  public class PostJobAndSkillAssignmentFilter
  {
    [XmlElement(DataType = "int", ElementName = "postKey", IsNullable = true)]
    public int? PostKey { get; set; }

    [XmlElement(DataType = "string", ElementName = "postDescription", IsNullable = true)]
    public string PostDescription { get; set; }

    [XmlElement(DataType = "string", ElementName = "populationFilter", IsNullable = true)]
    public string PopulationFilter { get; set; }
  }
}
