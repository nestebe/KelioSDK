﻿
//.ExportPlannedDailyJobTotalsFromDateToDateForEmployeeListResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportPlannedDailyJobTotalsFromDateToDateForEmployeeListResponse")]
  public class ExportPlannedDailyJobTotalsFromDateToDateForEmployeeListResponse
  {
    [XmlArray(ElementName = "exportedDailyJobTotals", IsNullable = false, Order = 0)]
    public List<DailyJobTotal> ExportedDailyJobTotals { get; set; }
  }
}
