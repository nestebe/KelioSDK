
//.ImportSkills




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importSkills")]
  public class ImportSkills
  {
    [XmlArray(ElementName = "skillsToImport", IsNullable = false, Order = 0)]
    public List<Skill> SkillsToImport { get; set; }
  }
}
