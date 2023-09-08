﻿
//.ExportPerpetualLatenessEarlyDepartureTotalsResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportPerpetualLatenessEarlyDepartureTotalsResponse")]
  public class ExportPerpetualLatenessEarlyDepartureTotalsResponse
  {
    [XmlArray(ElementName = "exportedPerpetualLatenessEarlyDepartureTotals", IsNullable = false, Order = 0)]
    public List<PerpetualLatenessEarlyDepartureTotal> ExportedPerpetualLatenessEarlyDepartureTotals { get; set; }
  }
}
