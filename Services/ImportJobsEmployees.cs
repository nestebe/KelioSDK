
//.ImportJobsEmployees




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importJobsEmployees")]
  public class ImportJobsEmployees
  {
    [XmlArray(ElementName = "jobsEmployeesToImport", IsNullable = false, Order = 0)]
    public List<EmployeeJob> JobsEmployeesToImport { get; set; }
  }
}
