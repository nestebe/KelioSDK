
//.ExportEmployeeAccessDataResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportEmployeeAccessDataResponse")]
  public class ExportEmployeeAccessDataResponse
  {
    [XmlArray(ElementName = "exportedEmployeeAccessData", IsNullable = false, Order = 0)]
    public List<EmployeeAccessData> ExportedEmployeeAccessData { get; set; }
  }
}
