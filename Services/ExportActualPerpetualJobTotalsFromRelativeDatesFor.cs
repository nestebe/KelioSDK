
//.ExportActualPerpetualJobTotalsFromRelativeDatesForEmployeeList




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportActualPerpetualJobTotalsFromRelativeDatesForEmployeeList")]
  public class ExportActualPerpetualJobTotalsFromRelativeDatesForEmployeeList
  {
    [XmlArray(ElementName = "employeeListForEmployeeList", IsNullable = false, Order = 0)]
    public List<AskedEmployeeWithRelativeDates> EmployeeListForEmployeeList { get; set; }
  }
}
