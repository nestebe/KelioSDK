
//.ExportActualDailyBonusTotalsFromDateToDateForEmployeeList




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportActualDailyBonusTotalsFromDateToDateForEmployeeList")]
  public class ExportActualDailyBonusTotalsFromDateToDateForEmployeeList
  {
    [XmlArray(ElementName = "employeeList", IsNullable = false, Order = 0)]
    public List<AskedEmployee> EmployeeList { get; set; }
  }
}
