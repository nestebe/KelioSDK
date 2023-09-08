
//.ExportJobAssignmentsList




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportJobAssignmentsList")]
  public class ExportJobAssignmentsList
  {
    [XmlArray(ElementName = "exportFilter", IsNullable = false, Order = 0)]
    public List<AskedJobAssignments> ExportFilter { get; set; }
  }
}
