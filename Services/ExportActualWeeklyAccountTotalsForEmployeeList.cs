﻿
//.ExportActualWeeklyAccountTotalsForEmployeeList




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportActualWeeklyAccountTotalsForEmployeeList")]
  public class ExportActualWeeklyAccountTotalsForEmployeeList
  {
    [XmlArray(ElementName = "employeeList", IsNullable = false, Order = 0)]
    public List<AskedEmployeeWithPeriod> EmployeeList { get; set; }
  }
}
