
//.ExportActualPerpetualJobTotalsListFromDateForEmployeeList




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportActualPerpetualJobTotalsListFromDateForEmployeeList")]
  public class ExportActualPerpetualJobTotalsListFromDateForEmployeeList
  {
    [XmlArray(ElementName = "employeeListForEmployeeList", IsNullable = false, Order = 0)]
    public List<AskedEmployeeWithDate> EmployeeListForEmployeeList { get; set; }
  }
}
