
//.ExportEmployeesTimeManagementDataListResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportEmployeesTimeManagementDataListResponse")]
  public class ExportEmployeesTimeManagementDataListResponse
  {
    [XmlArray(ElementName = "exportedEmployeesTimeManagementData", IsNullable = false, Order = 0)]
    public List<EmployeeTimeManagementData> ExportedEmployeesTimeManagementData { get; set; }
  }
}
