﻿
//.ExportEstimatedDailyOvertimeHourTotalsFromPeriodForEmployeeListResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportEstimatedDailyOvertimeHourTotalsFromPeriodForEmployeeListResponse")]
  public class ExportEstimatedDailyOvertimeHourTotalsFromPeriodForEmployeeListResponse
  {
    [XmlArray(ElementName = "exportedDailyOvertimeHourTotals", IsNullable = false, Order = 0)]
    public List<DailyOvertimeHourTotal> ExportedDailyOvertimeHourTotals { get; set; }
  }
}
