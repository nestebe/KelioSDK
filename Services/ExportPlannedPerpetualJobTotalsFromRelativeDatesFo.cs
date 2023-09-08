
//.ExportPlannedPerpetualJobTotalsFromRelativeDatesForEmployeeList




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportPlannedPerpetualJobTotalsFromRelativeDatesForEmployeeList")]
  public class ExportPlannedPerpetualJobTotalsFromRelativeDatesForEmployeeList
  {
    [XmlArray(ElementName = "employeeListForEmployeeList", IsNullable = false, Order = 0)]
    public List<AskedEmployeeWithRelativeDates> EmployeeListForEmployeeList { get; set; }
  }
}
