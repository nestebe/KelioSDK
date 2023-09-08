
//.ExportSkillAssignmentsListResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportSkillAssignmentsListResponse")]
  public class ExportSkillAssignmentsListResponse
  {
    [XmlArray(ElementName = "exportedSkillAssignments", IsNullable = false, Order = 0)]
    public List<SkillAssignment> ExportedSkillAssignments { get; set; }
  }
}
