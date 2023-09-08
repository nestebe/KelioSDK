
//.ExportEmployeesResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportEmployeesResponse")]
  public class ExportEmployeesResponse
  {
    [XmlArray(ElementName = "exportedEmployees", IsNullable = false, Order = 0)]
    public List<Employee> ExportedEmployees { get; set; }
  }
}
