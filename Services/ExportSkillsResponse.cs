
//.ExportSkillsResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportSkillsResponse")]
  public class ExportSkillsResponse
  {
    [XmlArray(ElementName = "exportedSkills", IsNullable = false, Order = 0)]
    public List<Skill> ExportedSkills { get; set; }
  }
}
