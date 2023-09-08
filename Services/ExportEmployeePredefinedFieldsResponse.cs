
//.ExportEmployeePredefinedFieldsResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportEmployeePredefinedFieldsResponse")]
  public class ExportEmployeePredefinedFieldsResponse
  {
    [XmlArray(ElementName = "exportedEmployeePredefinedFields", IsNullable = false, Order = 0)]
    public List<EmployeeField> ExportedEmployeePredefinedFields { get; set; }
  }
}
