
//.ImportJobsEmployeesResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importJobsEmployeesResponse")]
  public class ImportJobsEmployeesResponse
  {
    [XmlArray(ElementName = "jobsEmployeesInError", IsNullable = false, Order = 0)]
    public List<EmployeeJob> JobsEmployeesInError { get; set; }
  }
}
