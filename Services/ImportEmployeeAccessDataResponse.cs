
//.ImportEmployeeAccessDataResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importEmployeeAccessDataResponse")]
  public class ImportEmployeeAccessDataResponse
  {
    [XmlArray(ElementName = "employeeAccessDataInError", IsNullable = false, Order = 0)]
    public List<EmployeeAccessData> EmployeeAccessDataInError { get; set; }
  }
}
