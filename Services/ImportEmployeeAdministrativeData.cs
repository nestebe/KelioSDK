
//.ImportEmployeeAdministrativeData




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importEmployeeAdministrativeData")]
  public class ImportEmployeeAdministrativeData
  {
    [XmlArray(ElementName = "employeeAdministrativeToImport", IsNullable = false, Order = 0)]
    public List<EmployeeAdministrativeData> EmployeeAdministrativeToImport { get; set; }
  }
}
