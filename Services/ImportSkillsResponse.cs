
//.ImportSkillsResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importSkillsResponse")]
  public class ImportSkillsResponse
  {
    [XmlArray(ElementName = "skillsInError", IsNullable = false, Order = 0)]
    public List<Skill> SkillsInError { get; set; }
  }
}
