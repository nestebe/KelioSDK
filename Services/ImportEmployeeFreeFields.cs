
//.ImportEmployeeFreeFields




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importEmployeeFreeFields")]
  public class ImportEmployeeFreeFields
  {
    [XmlArray(ElementName = "employeeFreeFieldsToImport", IsNullable = false, Order = 0)]
    public List<EmployeeField> EmployeeFreeFieldsToImport { get; set; }
  }
}
