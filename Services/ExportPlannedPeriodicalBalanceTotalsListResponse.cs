﻿
//.ExportPlannedPeriodicalBalanceTotalsListResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportPlannedPeriodicalBalanceTotalsListResponse")]
  public class ExportPlannedPeriodicalBalanceTotalsListResponse
  {
    [XmlArray(ElementName = "exportedPeriodicalBalanceTotals", IsNullable = false, Order = 0)]
    public List<PeriodicBalanceTotal> ExportedPeriodicalBalanceTotals { get; set; }
  }
}
