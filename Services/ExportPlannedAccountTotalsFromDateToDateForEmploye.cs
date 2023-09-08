
//.ExportPlannedAccountTotalsFromDateToDateForEmployeeList




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportPlannedAccountTotalsFromDateToDateForEmployeeList")]
  public class ExportPlannedAccountTotalsFromDateToDateForEmployeeList
  {
    [XmlArray(ElementName = "employeeList", IsNullable = false, Order = 0)]
    public List<AskedEmployee> EmployeeList { get; set; }
  }
}
