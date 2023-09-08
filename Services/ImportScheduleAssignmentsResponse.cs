
//.ImportScheduleAssignmentsResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importScheduleAssignmentsResponse")]
  public class ImportScheduleAssignmentsResponse
  {
    [XmlArray(ElementName = "scheduleAssignmentsInError", IsNullable = false, Order = 0)]
    public List<ScheduleAssignment> ScheduleAssignmentsInError { get; set; }
  }
}
