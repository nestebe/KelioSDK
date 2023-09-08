﻿
//.ExportPlannedAbsenceBalanceTotalsFromDateToDateForEmployeeListResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportPlannedAbsenceBalanceTotalsFromDateToDateForEmployeeListResponse")]
  public class ExportPlannedAbsenceBalanceTotalsFromDateToDateForEmployeeListResponse
  {
    [XmlArray(ElementName = "exportedFromDateToDateAbsenceBalanceTotals", IsNullable = false, Order = 0)]
    public List<FromDateToDateAbsenceBalanceTotal> ExportedFromDateToDateAbsenceBalanceTotals { get; set; }
  }
}
