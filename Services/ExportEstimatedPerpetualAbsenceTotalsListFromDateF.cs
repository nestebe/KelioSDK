
//.ExportEstimatedPerpetualAbsenceTotalsListFromDateForEmployeeList




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportEstimatedPerpetualAbsenceTotalsListFromDateForEmployeeList")]
  public class ExportEstimatedPerpetualAbsenceTotalsListFromDateForEmployeeList
  {
    [XmlArray(ElementName = "employeeList", IsNullable = false, Order = 0)]
    public List<AskedEmployeeWithDate> EmployeeList { get; set; }
  }
}
