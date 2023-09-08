
//.ImportJobAssignments




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importJobAssignments")]
  public class ImportJobAssignments
  {
    [XmlArray(ElementName = "jobAssignmentsToImport", IsNullable = false, Order = 0)]
    public List<JobAssignment> JobAssignmentsToImport { get; set; }
  }
}
