
//.ExportAutoExitAssignmentWindowsListResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportAutoExitAssignmentWindowsListResponse")]
  public class ExportAutoExitAssignmentWindowsListResponse
  {
    [XmlArray(ElementName = "exportedAutoExitAssignmentWindows", IsNullable = false, Order = 0)]
    public List<AutoExitAssignment> ExportedAutoExitAssignmentWindows { get; set; }
  }
}
