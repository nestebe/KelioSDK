
//.ImportEmployeePrivateDataResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importEmployeePrivateDataResponse")]
  public class ImportEmployeePrivateDataResponse
  {
    [XmlArray(ElementName = "employeePrivateDataInError", IsNullable = false, Order = 0)]
    public List<EmployeePrivateData> EmployeePrivateDataInError { get; set; }
  }
}
