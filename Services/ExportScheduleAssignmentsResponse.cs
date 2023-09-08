﻿
//.ExportScheduleAssignmentsResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportScheduleAssignmentsResponse")]
  public class ExportScheduleAssignmentsResponse
  {
    [XmlArray(ElementName = "exportedScheduleAssignments", IsNullable = false, Order = 0)]
    public List<ScheduleAssignment> ExportedScheduleAssignments { get; set; }
  }
}
