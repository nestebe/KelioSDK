
//.ExportJobsEmployeesResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportJobsEmployeesResponse")]
  public class ExportJobsEmployeesResponse
  {
    [XmlArray(ElementName = "exportedJobsEmployees", IsNullable = false, Order = 0)]
    public List<EmployeeJob> ExportedJobsEmployees { get; set; }
  }
}
