
//.ExportScheduleByExceptionAssignmentsResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportScheduleByExceptionAssignmentsResponse")]
  public class ExportScheduleByExceptionAssignmentsResponse
  {
    [XmlArray(ElementName = "exportedScheduleByExceptionAssignments", IsNullable = false, Order = 0)]
    public List<ScheduleByExceptionAssignment> ExportedScheduleByExceptionAssignments { get; set; }
  }
}
