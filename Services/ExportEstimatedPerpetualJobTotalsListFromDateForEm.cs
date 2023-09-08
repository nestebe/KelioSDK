﻿
//.ExportEstimatedPerpetualJobTotalsListFromDateForEmployeeList




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportEstimatedPerpetualJobTotalsListFromDateForEmployeeList")]
  public class ExportEstimatedPerpetualJobTotalsListFromDateForEmployeeList
  {
    [XmlArray(ElementName = "employeeListForEmployeeList", IsNullable = false, Order = 0)]
    public List<AskedEmployeeWithDate> EmployeeListForEmployeeList { get; set; }
  }
}
