﻿
//.ExportPeriodicalCalculatedPeriodListResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportPeriodicalCalculatedPeriodListResponse")]
  public class ExportPeriodicalCalculatedPeriodListResponse
  {
    [XmlArray(ElementName = "exportedPeriodicalCalculatedPeriod", IsNullable = false, Order = 0)]
    public List<CalculatedPeriod> ExportedPeriodicalCalculatedPeriod { get; set; }
  }
}
