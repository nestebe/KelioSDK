
//.ImportEmployeeJobDataResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importEmployeeJobDataResponse")]
  public class ImportEmployeeJobDataResponse
  {
    [XmlArray(ElementName = "employeeJobDataInError", IsNullable = false, Order = 0)]
    public List<EmployeeJobData> EmployeeJobDataInError { get; set; }
  }
}
