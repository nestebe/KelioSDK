
// Type: KelioSDK.Models.Skill




using KelioSDK.Common;
using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "Skill")]
  public class Skill : ObjectBase
  {
    [XmlElement(DataType = "string", ElementName = "skillAbbreviation", IsNullable = true)]
    public string SkillAbbreviation { get; set; }

    [XmlElement(DataType = "string", ElementName = "skillDescription", IsNullable = true)]
    public string SkillDescription { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "searchSkillUsingAbbreviation", IsNullable = true)]
    public bool? SearchSkillUsingAbbreviation { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "searchSkillUsingDescription", IsNullable = true)]
    public bool? SearchSkillUsingDescription { get; set; }

    [XmlElement(DataType = "int", ElementName = "skillKey", IsNullable = true)]
    public int? SkillKey { get; set; }
  }
}
