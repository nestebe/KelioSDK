﻿
//.ExportPlannedPeriodicalAbsenceTotalsListFromDateToDateForEmployeeListResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportPlannedPeriodicalAbsenceTotalsListFromDateToDateForEmployeeListResponse")]
  public class ExportPlannedPeriodicalAbsenceTotalsListFromDateToDateForEmployeeListResponse
  {
    [XmlArray(ElementName = "exportedPeriodicalAbsenceTotals", IsNullable = false, Order = 0)]
    public List<PeriodicAbsenceTotal> ExportedPeriodicalAbsenceTotals { get; set; }
  }
}
