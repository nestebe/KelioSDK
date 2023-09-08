
//.ImportSectionAssignments




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importSectionAssignments")]
  public class ImportSectionAssignments
  {
    [XmlArray(ElementName = "sectionAssignmentsToImport", IsNullable = false, Order = 0)]
    public List<SectionAssignment> SectionAssignmentsToImport { get; set; }
  }
}
