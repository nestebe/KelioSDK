
//.ExportActualJobTotalsFromDateToDateForEmployeeList




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportActualJobTotalsFromDateToDateForEmployeeList")]
  public class ExportActualJobTotalsFromDateToDateForEmployeeList
  {
    [XmlArray(ElementName = "employeeListForEmployeeList", IsNullable = false, Order = 0)]
    public List<AskedEmployee> EmployeeListForEmployeeList { get; set; }
  }
}
