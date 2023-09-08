﻿
//.ExportPlannedDailyJobTotalsFromPeriodResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportPlannedDailyJobTotalsFromPeriodResponse")]
  public class ExportPlannedDailyJobTotalsFromPeriodResponse
  {
    [XmlArray(ElementName = "exportedDailyJobTotals", IsNullable = false, Order = 0)]
    public List<DailyJobTotal> ExportedDailyJobTotals { get; set; }
  }
}
