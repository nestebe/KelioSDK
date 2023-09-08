
//.ExportCalculationFunctionExecutionsFromDateToDateForEmployeeList




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportCalculationFunctionExecutionsFromDateToDateForEmployeeList")]
  public class ExportCalculationFunctionExecutionsFromDateToDateForEmployeeList
  {
    [XmlArray(ElementName = "employeeList", IsNullable = false, Order = 0)]
    public List<AskedEmployeeWithFunctionType> EmployeeList { get; set; }
  }
}
