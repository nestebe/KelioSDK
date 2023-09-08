
//.DeleteDailyScheduleAssignments




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "deleteDailyScheduleAssignments")]
  public class DeleteDailyScheduleAssignments
  {
    [XmlArray(ElementName = "dailyScheduleAssignmentsToDelete", IsNullable = false, Order = 0)]
    public List<DailyScheduleAssignment> DailyScheduleAssignmentsToDelete { get; set; }
  }
}
