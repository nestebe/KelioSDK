
//.ExportEmployeePrivateDataResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportEmployeePrivateDataResponse")]
  public class ExportEmployeePrivateDataResponse
  {
    [XmlArray(ElementName = "exportedEmployeePrivateData", IsNullable = false, Order = 0)]
    public List<EmployeePrivateData> ExportedEmployeePrivateData { get; set; }
  }
}
