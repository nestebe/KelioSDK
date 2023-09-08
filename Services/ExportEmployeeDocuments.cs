
//.ExportEmployeeDocuments




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportEmployeeDocuments")]
  public class ExportEmployeeDocuments
  {
    [XmlArray(ElementName = "exportFilter", IsNullable = false, Order = 0)]
    public List<AskedEmployeeDocument> ExportFilter { get; set; }
  }
}
