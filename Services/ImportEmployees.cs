
//.ImportEmployees




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importEmployees")]
  public class ImportEmployees
  {
    [XmlArray(ElementName = "employeesToImport", IsNullable = false, Order = 0)]
    public List<Employee> EmployeesToImport { get; set; }
  }
}
