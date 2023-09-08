
//.ExportSectionAssignmentsListResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportSectionAssignmentsListResponse")]
  public class ExportSectionAssignmentsListResponse
  {
    [XmlArray(ElementName = "exportedSectionAssignments", IsNullable = false, Order = 0)]
    public List<SectionAssignment> ExportedSectionAssignments { get; set; }
  }
}
