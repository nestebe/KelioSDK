
//.ExportEmployeeDocumentsResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportEmployeeDocumentsResponse")]
  public class ExportEmployeeDocumentsResponse
  {
    [XmlArray(ElementName = "exportedEmployeeDocuments", IsNullable = false, Order = 0)]
    public List<EmployeeDocument> ExportedEmployeeDocuments { get; set; }
  }
}
