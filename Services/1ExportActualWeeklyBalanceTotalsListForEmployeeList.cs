﻿
//.ExportActualWeeklyBalanceTotalsListForEmployeeListResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportActualWeeklyBalanceTotalsListForEmployeeListResponse")]
  public class ExportActualWeeklyBalanceTotalsListForEmployeeListResponse
  {
    [XmlArray(ElementName = "exportedWeeklyBalanceTotals", IsNullable = false, Order = 0)]
    public List<WeeklyBalanceTotal> ExportedWeeklyBalanceTotals { get; set; }
  }
}
