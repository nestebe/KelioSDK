﻿
//.ExportActualPerpetualOnCallDutyTotalsListFromDateForEmployeeList




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportActualPerpetualOnCallDutyTotalsListFromDateForEmployeeList")]
  public class ExportActualPerpetualOnCallDutyTotalsListFromDateForEmployeeList
  {
    [XmlArray(ElementName = "employeeList", IsNullable = false, Order = 0)]
    public List<AskedEmployeeWithDate> EmployeeList { get; set; }
  }
}
