﻿
//.ExportEstimatedPeriodicalJobTotalsResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportEstimatedPeriodicalJobTotalsResponse")]
  public class ExportEstimatedPeriodicalJobTotalsResponse
  {
    [XmlArray(ElementName = "exportedPeriodicalJobTotals", IsNullable = false, Order = 0)]
    public List<PeriodJobTotal> ExportedPeriodicalJobTotals { get; set; }
  }
}
