﻿
//.ExportActualPeriodicalLatenessEarlyDepartureTotalsListForEmployeeListResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportActualPeriodicalLatenessEarlyDepartureTotalsListForEmployeeListResponse")]
  public class ExportActualPeriodicalLatenessEarlyDepartureTotalsListForEmployeeListResponse
  {
    [XmlArray(ElementName = "exportedPeriodicalLatenessEarlyDepartureTotals", IsNullable = false, Order = 0)]
    public List<PeriodicLatenessEarlyDepartureTotal> ExportedPeriodicalLatenessEarlyDepartureTotals { get; set; }
  }
}
