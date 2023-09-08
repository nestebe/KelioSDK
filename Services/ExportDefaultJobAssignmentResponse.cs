
//.ExportDefaultJobAssignmentResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportDefaultJobAssignmentResponse")]
  public class ExportDefaultJobAssignmentResponse
  {
    [XmlArray(ElementName = "exportedDefaultJobAssignment", IsNullable = false, Order = 0)]
    public List<DefaultJobAssignment> ExportedDefaultJobAssignment { get; set; }
  }
}
