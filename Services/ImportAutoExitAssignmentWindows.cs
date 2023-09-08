
//.ImportAutoExitAssignmentWindows




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importAutoExitAssignmentWindows")]
  public class ImportAutoExitAssignmentWindows
  {
    [XmlArray(ElementName = "autoExitAssignmentWindowsToImport", IsNullable = false, Order = 0)]
    public List<AutoExitAssignment> AutoExitAssignmentWindowsToImport { get; set; }
  }
}
