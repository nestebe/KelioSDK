﻿
//.ExportActualPeriodicalAbsenceBalanceTotalsForEmployeeListResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportActualPeriodicalAbsenceBalanceTotalsForEmployeeListResponse")]
  public class ExportActualPeriodicalAbsenceBalanceTotalsForEmployeeListResponse
  {
    [XmlArray(ElementName = "exportedPeriodicalAbsenceBalanceTotals", IsNullable = false, Order = 0)]
    public List<PeriodicAbsenceBalanceTotal> ExportedPeriodicalAbsenceBalanceTotals { get; set; }
  }
}
