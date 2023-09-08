
//.ImportAccessProfileAssignments




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importAccessProfileAssignments")]
  public class ImportAccessProfileAssignments
  {
    [XmlArray(ElementName = "accessProfileAssignmentsToImport", IsNullable = false, Order = 0)]
    public List<AccessProfileAssignment> AccessProfileAssignmentsToImport { get; set; }
  }
}
