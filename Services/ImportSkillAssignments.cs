
//.ImportSkillAssignments




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importSkillAssignments")]
  public class ImportSkillAssignments
  {
    [XmlArray(ElementName = "skillAssignmentsToImport", IsNullable = false, Order = 0)]
    public List<SkillAssignment> SkillAssignmentsToImport { get; set; }
  }
}
