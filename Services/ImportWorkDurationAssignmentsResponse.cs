
//.ImportWorkDurationAssignmentsResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importWorkDurationAssignmentsResponse")]
  public class ImportWorkDurationAssignmentsResponse
  {
    [XmlArray(ElementName = "workDurationAssignmentsInError", IsNullable = false, Order = 0)]
    public List<WorkDurationAssignments> WorkDurationAssignmentsInError { get; set; }
  }
}
