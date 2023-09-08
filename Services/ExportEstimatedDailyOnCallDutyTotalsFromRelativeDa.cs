
//.ExportEstimatedDailyOnCallDutyTotalsFromRelativeDatesForEmployeeList




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportEstimatedDailyOnCallDutyTotalsFromRelativeDatesForEmployeeList")]
  public class ExportEstimatedDailyOnCallDutyTotalsFromRelativeDatesForEmployeeList
  {
    [XmlArray(ElementName = "employeeList", IsNullable = false, Order = 0)]
    public List<AskedEmployeeWithRelativeDates> EmployeeList { get; set; }
  }
}
