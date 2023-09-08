
//.ImportEmployeeAdministrativeDataResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importEmployeeAdministrativeDataResponse")]
  public class ImportEmployeeAdministrativeDataResponse
  {
    [XmlArray(ElementName = "EmployeeAdministrativeDataInError", IsNullable = false, Order = 0)]
    public List<EmployeeAdministrativeData> EmployeeAdministrativeDataInError { get; set; }
  }
}
