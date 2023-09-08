
//.ExportActualDailyOvertimeHourTotalsFromPeriodForEmployeeList




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportActualDailyOvertimeHourTotalsFromPeriodForEmployeeList")]
  public class ExportActualDailyOvertimeHourTotalsFromPeriodForEmployeeList
  {
    [XmlArray(ElementName = "employeeList", IsNullable = false, Order = 0)]
    public List<AskedEmployeeWithPeriod> EmployeeList { get; set; }
  }
}
