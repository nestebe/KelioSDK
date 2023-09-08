﻿
//.ExportEstimatedGenericTotalsFromDateToDateForEmployeeListResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportEstimatedGenericTotalsFromDateToDateForEmployeeListResponse")]
  public class ExportEstimatedGenericTotalsFromDateToDateForEmployeeListResponse
  {
    [XmlArray(ElementName = "exportedFromDateToDateGenericTotals", IsNullable = false, Order = 0)]
    public List<FromDateToDateGenericTotal> ExportedFromDateToDateGenericTotals { get; set; }
  }
}
