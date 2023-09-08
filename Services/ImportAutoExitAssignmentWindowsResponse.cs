
//.ImportAutoExitAssignmentWindowsResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importAutoExitAssignmentWindowsResponse")]
  public class ImportAutoExitAssignmentWindowsResponse
  {
    [XmlArray(ElementName = "autoExitAssignmentWindowsInError", IsNullable = false, Order = 0)]
    public List<AutoExitAssignment> AutoExitAssignmentWindowsInError { get; set; }
  }
}
