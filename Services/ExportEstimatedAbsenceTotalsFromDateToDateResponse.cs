﻿
//.ExportEstimatedAbsenceTotalsFromDateToDateResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportEstimatedAbsenceTotalsFromDateToDateResponse")]
  public class ExportEstimatedAbsenceTotalsFromDateToDateResponse
  {
    [XmlArray(ElementName = "exportedFromDateToDateAbsenceTotals", IsNullable = false, Order = 0)]
    public List<FromDateToDateAbsenceTotal> ExportedFromDateToDateAbsenceTotals { get; set; }
  }
}
