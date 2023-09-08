﻿
//.ExportEstimatedDailyLatenessEarlyDepartureTotalsFromPeriodResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportEstimatedDailyLatenessEarlyDepartureTotalsFromPeriodResponse")]
  public class ExportEstimatedDailyLatenessEarlyDepartureTotalsFromPeriodResponse
  {
    [XmlArray(ElementName = "exportedDailyLatenessEarlyDepartureTotals", IsNullable = false, Order = 0)]
    public List<DailyLatenessEarlyDepartureTotal> ExportedDailyLatenessEarlyDepartureTotals { get; set; }
  }
}
