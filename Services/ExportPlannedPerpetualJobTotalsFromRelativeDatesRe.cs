﻿
//.ExportPlannedPerpetualJobTotalsFromRelativeDatesResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportPlannedPerpetualJobTotalsFromRelativeDatesResponse")]
  public class ExportPlannedPerpetualJobTotalsFromRelativeDatesResponse
  {
    [XmlArray(ElementName = "exportedPerpetualJobTotals", IsNullable = false, Order = 0)]
    public List<PerpetualJobTotal> ExportedPerpetualJobTotals { get; set; }
  }
}
