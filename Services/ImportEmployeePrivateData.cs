
//.ImportEmployeePrivateData




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importEmployeePrivateData")]
  public class ImportEmployeePrivateData
  {
    [XmlArray(ElementName = "employeePrivateDataToImport", IsNullable = false, Order = 0)]
    public List<EmployeePrivateData> EmployeePrivateDataToImport { get; set; }
  }
}
