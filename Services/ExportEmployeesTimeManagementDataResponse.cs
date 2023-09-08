
//.ExportEmployeesTimeManagementDataResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportEmployeesTimeManagementDataResponse")]
  public class ExportEmployeesTimeManagementDataResponse
  {
    [XmlArray(ElementName = "exportedEmployeesTimeManagementData", IsNullable = false, Order = 0)]
    public List<EmployeeTimeManagementData> ExportedEmployeesTimeManagementData { get; set; }
  }
}
