
//.ImportEmployeePredefinedFields




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importEmployeePredefinedFields")]
  public class ImportEmployeePredefinedFields
  {
    [XmlArray(ElementName = "employeePredefinedFieldsToImport", IsNullable = false, Order = 0)]
    public List<EmployeeField> EmployeePredefinedFieldsToImport { get; set; }
  }
}
