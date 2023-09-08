
//.ExportEstimatedPeriodicalSpecialHourTotalsListFromDateToDateForEmployeeList




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportEstimatedPeriodicalSpecialHourTotalsListFromDateToDateForEmployeeList")]
  public class ExportEstimatedPeriodicalSpecialHourTotalsListFromDateToDateForEmployeeList
  {
    [XmlArray(ElementName = "employeeList", IsNullable = false, Order = 0)]
    public List<AskedEmployee> EmployeeList { get; set; }
  }
}
