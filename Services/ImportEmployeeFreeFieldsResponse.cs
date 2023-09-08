
//.ImportEmployeeFreeFieldsResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importEmployeeFreeFieldsResponse")]
  public class ImportEmployeeFreeFieldsResponse
  {
    [XmlArray(ElementName = "employeeFreeFieldsInError", IsNullable = false, Order = 0)]
    public List<EmployeeField> EmployeeFreeFieldsInError { get; set; }
  }
}
