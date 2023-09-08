
//.DeleteDailyScheduleAssignmentsResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "deleteDailyScheduleAssignmentsResponse")]
  public class DeleteDailyScheduleAssignmentsResponse
  {
    [XmlArray(ElementName = "dailyScheduleAssignmentsInError", IsNullable = false, Order = 0)]
    public List<DailyScheduleAssignment> DailyScheduleAssignmentsInError { get; set; }
  }
}
