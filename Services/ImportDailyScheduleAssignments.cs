
//.ImportDailyScheduleAssignments




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importDailyScheduleAssignments")]
  public class ImportDailyScheduleAssignments
  {
    [XmlArray(ElementName = "dailyScheduleAssignmentsToImport", IsNullable = false, Order = 0)]
    public List<DailyScheduleAssignment> DailyScheduleAssignmentsToImport { get; set; }
  }
}
