
//.ExportEmployeeUserDataListResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportEmployeeUserDataListResponse")]
  public class ExportEmployeeUserDataListResponse
  {
    [XmlArray(ElementName = "exportedEmployeeUserData", IsNullable = false, Order = 0)]
    public List<EmployeeUserData> ExportedEmployeeUserData { get; set; }
  }
}
