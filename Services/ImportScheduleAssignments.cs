
//.ImportScheduleAssignments




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importScheduleAssignments")]
  public class ImportScheduleAssignments
  {
    [XmlArray(ElementName = "scheduleAssignmentsToImport", IsNullable = false, Order = 0)]
    public List<ScheduleAssignment> ScheduleAssignmentsToImport { get; set; }
  }
}
