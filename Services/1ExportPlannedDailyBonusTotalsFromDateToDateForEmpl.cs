﻿
//.ExportPlannedDailyBonusTotalsFromDateToDateForEmployeeListResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportPlannedDailyBonusTotalsFromDateToDateForEmployeeListResponse")]
  public class ExportPlannedDailyBonusTotalsFromDateToDateForEmployeeListResponse
  {
    [XmlArray(ElementName = "exportedDailyBonusTotals", IsNullable = false, Order = 0)]
    public List<DailyBonusTotal> ExportedDailyBonusTotals { get; set; }
  }
}
