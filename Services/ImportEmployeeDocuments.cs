
//.ImportEmployeeDocuments




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importEmployeeDocuments")]
  public class ImportEmployeeDocuments
  {
    [XmlArray(ElementName = "employeeDocumentsToImport", IsNullable = false, Order = 0)]
    public List<EmployeeDocument> EmployeeDocumentsToImport { get; set; }
  }
}
