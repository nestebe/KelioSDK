﻿
//.ExportEstimatedLatenessEarlyDepartureTotalsFromDateToDateResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportEstimatedLatenessEarlyDepartureTotalsFromDateToDateResponse")]
  public class ExportEstimatedLatenessEarlyDepartureTotalsFromDateToDateResponse
  {
    [XmlArray(ElementName = "exportedFromDateToDateLatenessEarlyDepartureTotals", IsNullable = false, Order = 0)]
    public List<FromDateToDateLatenessEarlyDepartureTotal> ExportedFromDateToDateLatenessEarlyDepartureTotals { get; set; }
  }
}
