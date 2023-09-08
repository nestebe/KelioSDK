
//.ImportSkillAssignmentsResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importSkillAssignmentsResponse")]
  public class ImportSkillAssignmentsResponse
  {
    [XmlArray(ElementName = "skillAssignmentsInError", IsNullable = false, Order = 0)]
    public List<SkillAssignment> SkillAssignmentsInError { get; set; }
  }
}
