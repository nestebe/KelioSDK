﻿
//.ExportEstimatedDailyAccountTotalsFromDateToDateForEmployeeListResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportEstimatedDailyAccountTotalsFromDateToDateForEmployeeListResponse")]
  public class ExportEstimatedDailyAccountTotalsFromDateToDateForEmployeeListResponse
  {
    [XmlArray(ElementName = "exportedDailyAccountTotals", IsNullable = false, Order = 0)]
    public List<DailyTotal> ExportedDailyAccountTotals { get; set; }
  }
}
