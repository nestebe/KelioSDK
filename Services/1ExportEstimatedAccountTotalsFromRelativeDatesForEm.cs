﻿
//.ExportEstimatedAccountTotalsFromRelativeDatesForEmployeeListResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportEstimatedAccountTotalsFromRelativeDatesForEmployeeListResponse")]
  public class ExportEstimatedAccountTotalsFromRelativeDatesForEmployeeListResponse
  {
    [XmlArray(ElementName = "exportedFromDateToDateAccountTotals", IsNullable = false, Order = 0)]
    public List<FromDateToDateTotal> ExportedFromDateToDateAccountTotals { get; set; }
  }
}
