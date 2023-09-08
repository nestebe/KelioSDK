
//.ExportEmployeeAdministrativeDataListResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportEmployeeAdministrativeDataListResponse")]
  public class ExportEmployeeAdministrativeDataListResponse
  {
    [XmlArray(ElementName = "exportedEmployeeAdministrativeData", IsNullable = false, Order = 0)]
    public List<EmployeeAdministrativeData> ExportedEmployeeAdministrativeData { get; set; }
  }
}
