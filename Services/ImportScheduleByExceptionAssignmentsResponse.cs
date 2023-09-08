
//.ImportScheduleByExceptionAssignmentsResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importScheduleByExceptionAssignmentsResponse")]
  public class ImportScheduleByExceptionAssignmentsResponse
  {
    [XmlArray(ElementName = "scheduleByExceptionAssignmentsInError", IsNullable = false, Order = 0)]
    public List<ScheduleByExceptionAssignment> ScheduleByExceptionAssignmentsInError { get; set; }
  }
}
