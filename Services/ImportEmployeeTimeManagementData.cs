
//.ImportEmployeeTimeManagementData




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importEmployeeTimeManagementData")]
  public class ImportEmployeeTimeManagementData
  {
    [XmlArray(ElementName = "employeeTimeManagementToImport", IsNullable = false, Order = 0)]
    public List<EmployeeTimeManagementData> EmployeeTimeManagementToImport { get; set; }
  }
}
