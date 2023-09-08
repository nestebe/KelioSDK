
//.ExportEmployeesListResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportEmployeesListResponse")]
  public class ExportEmployeesListResponse
  {
    [XmlArray(ElementName = "exportedEmployees", IsNullable = false, Order = 0)]
    public List<Employee> ExportedEmployees { get; set; }
  }
}
