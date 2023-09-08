
//.ExportPlannedPerpetualJobTotalsListForEmployeeList




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportPlannedPerpetualJobTotalsListForEmployeeList")]
  public class ExportPlannedPerpetualJobTotalsListForEmployeeList
  {
    [XmlArray(ElementName = "employeeListForEmployeeList", IsNullable = false, Order = 0)]
    public List<AskedEmployeeWithPeriod> EmployeeListForEmployeeList { get; set; }
  }
}
