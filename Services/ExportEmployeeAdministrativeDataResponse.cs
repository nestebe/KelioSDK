
//.ExportEmployeeAdministrativeDataResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportEmployeeAdministrativeDataResponse")]
  public class ExportEmployeeAdministrativeDataResponse
  {
    [XmlArray(ElementName = "exportedEmployeeAdministrativeData", IsNullable = false, Order = 0)]
    public List<EmployeeAdministrativeData> ExportedEmployeeAdministrativeData { get; set; }
  }
}
