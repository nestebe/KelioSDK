﻿
//.ExportPlannedDailyOnCallDutyTotalsFromDateToDateForEmployeeListResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportPlannedDailyOnCallDutyTotalsFromDateToDateForEmployeeListResponse")]
  public class ExportPlannedDailyOnCallDutyTotalsFromDateToDateForEmployeeListResponse
  {
    [XmlArray(ElementName = "exportedDailyOnCallDutyTotals", IsNullable = false, Order = 0)]
    public List<DailyOnCallDutyTotal> ExportedDailyOnCallDutyTotals { get; set; }
  }
}
