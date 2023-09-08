﻿
//.ExportDailyScheduleAssignmentsFromEmployeeListResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportDailyScheduleAssignmentsFromEmployeeListResponse")]
  public class ExportDailyScheduleAssignmentsFromEmployeeListResponse
  {
    [XmlArray(ElementName = "exportedDailyScheduleAssignments", IsNullable = false, Order = 0)]
    public List<DailyScheduleAssignment> ExportedDailyScheduleAssignments { get; set; }
  }
}
