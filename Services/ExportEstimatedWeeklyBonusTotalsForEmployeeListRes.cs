﻿
//.ExportEstimatedWeeklyBonusTotalsForEmployeeListResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportEstimatedWeeklyBonusTotalsForEmployeeListResponse")]
  public class ExportEstimatedWeeklyBonusTotalsForEmployeeListResponse
  {
    [XmlArray(ElementName = "exportedWeeklyBonusTotals", IsNullable = false, Order = 0)]
    public List<WeeklyBonusTotal> ExportedWeeklyBonusTotals { get; set; }
  }
}
