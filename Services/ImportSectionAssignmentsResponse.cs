
//.ImportSectionAssignmentsResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importSectionAssignmentsResponse")]
  public class ImportSectionAssignmentsResponse
  {
    [XmlArray(ElementName = "sectionAssignmentsInError", IsNullable = false, Order = 0)]
    public List<SectionAssignment> SectionAssignmentsInError { get; set; }
  }
}
