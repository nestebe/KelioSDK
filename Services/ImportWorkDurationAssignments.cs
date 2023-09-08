
//.ImportWorkDurationAssignments




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importWorkDurationAssignments")]
  public class ImportWorkDurationAssignments
  {
    [XmlArray(ElementName = "workDurationAssignmentsToImport", IsNullable = false, Order = 0)]
    public List<WorkDurationAssignments> WorkDurationAssignmentsToImport { get; set; }
  }
}
