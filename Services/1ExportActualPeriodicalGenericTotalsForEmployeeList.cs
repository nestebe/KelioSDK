﻿
//.ExportActualPeriodicalGenericTotalsForEmployeeListResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportActualPeriodicalGenericTotalsForEmployeeListResponse")]
  public class ExportActualPeriodicalGenericTotalsForEmployeeListResponse
  {
    [XmlArray(ElementName = "exportedPeriodicalGenericTotals", IsNullable = false, Order = 0)]
    public List<PeriodicGenericTotal> ExportedPeriodicalGenericTotals { get; set; }
  }
}
