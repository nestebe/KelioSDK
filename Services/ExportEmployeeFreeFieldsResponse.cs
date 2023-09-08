
//.ExportEmployeeFreeFieldsResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportEmployeeFreeFieldsResponse")]
  public class ExportEmployeeFreeFieldsResponse
  {
    [XmlArray(ElementName = "exportedEmployeeFreeFields", IsNullable = false, Order = 0)]
    public List<EmployeeField> ExportedEmployeeFreeFields { get; set; }
  }
}
