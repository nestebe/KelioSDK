
// Type: KelioSDK.Models.PostJobAndSkillAssignmentAction




using KelioSDK.Common;
using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "PostJobAndSkillAssignmentAction")]
  public class PostJobAndSkillAssignmentAction : ObjectBase
  {
    [XmlElement(DataType = "int", ElementName = "priority", IsNullable = true)]
    public int? Priority { get; set; }

    [XmlElement(DataType = "int", ElementName = "level", IsNullable = true)]
    public int? Level { get; set; }

    [XmlElement(DataType = "string", ElementName = "jobRequiredAbbreviation", IsNullable = true)]
    public string JobRequiredAbbreviation { get; set; }

    [XmlElement(DataType = "string", ElementName = "postType", IsNullable = true)]
    public string PostType { get; set; }

    [XmlElement(DataType = "int", ElementName = "postKey", IsNullable = true)]
    public int? PostKey { get; set; }

    [XmlElement(DataType = "string", ElementName = "postDescription", IsNullable = true)]
    public string PostDescription { get; set; }

    [XmlElement(DataType = "string", ElementName = "SkillDescription", IsNullable = true)]
    public string SkillDescription { get; set; }

    [XmlElement(DataType = "string", ElementName = "jobRequiredTitle", IsNullable = true)]
    public string JobRequiredTitle { get; set; }

    [XmlElement(DataType = "string", ElementName = "SkillAbbreviation", IsNullable = true)]
    public string SkillAbbreviation { get; set; }

    [XmlElement(DataType = "string", ElementName = "levelDescription", IsNullable = true)]
    public string LevelDescription { get; set; }

    [XmlElement(DataType = "int", ElementName = "lineAssignment", IsNullable = true)]
    public int? LineAssignment { get; set; }

    [XmlElement(DataType = "string", ElementName = "levelAbbreviation", IsNullable = true)]
    public string LevelAbbreviation { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "requireAllSkills", IsNullable = true)]
    public bool? RequireAllSkills { get; set; }

    [XmlElement(DataType = "string", ElementName = "populationFilter", IsNullable = true)]
    public string PopulationFilter { get; set; }
  }
}
