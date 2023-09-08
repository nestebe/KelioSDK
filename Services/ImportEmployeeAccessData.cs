
//.ImportEmployeeAccessData




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importEmployeeAccessData")]
  public class ImportEmployeeAccessData
  {
    [XmlArray(ElementName = "employeeAccessToImport", IsNullable = false, Order = 0)]
    public List<EmployeeAccessData> EmployeeAccessToImport { get; set; }
  }
}
