﻿
//.ExportEstimatedJobTotalsFromDateToDateForEmployeeListResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportEstimatedJobTotalsFromDateToDateForEmployeeListResponse")]
  public class ExportEstimatedJobTotalsFromDateToDateForEmployeeListResponse
  {
    [XmlArray(ElementName = "exportedFromDateToDateJobTotals", IsNullable = false, Order = 0)]
    public List<FromDateToDateJobTotal> ExportedFromDateToDateJobTotals { get; set; }
  }
}
