
//.ExportSkillAssignmentsResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportSkillAssignmentsResponse")]
  public class ExportSkillAssignmentsResponse
  {
    [XmlArray(ElementName = "exportedSkillAssignments", IsNullable = false, Order = 0)]
    public List<SkillAssignment> ExportedSkillAssignments { get; set; }
  }
}
