
//.ExportDailyScheduleAssignmentsResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportDailyScheduleAssignmentsResponse")]
  public class ExportDailyScheduleAssignmentsResponse
  {
    [XmlArray(ElementName = "exportedDailyScheduleAssignments", IsNullable = false, Order = 0)]
    public List<DailyScheduleAssignment> ExportedDailyScheduleAssignments { get; set; }
  }
}
