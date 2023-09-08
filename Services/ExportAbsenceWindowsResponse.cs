
//.ExportAbsenceWindowsResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportAbsenceWindowsResponse")]
  public class ExportAbsenceWindowsResponse
  {
    [XmlArray(ElementName = "exportedAbsenceWindows", IsNullable = false, Order = 0)]
    public List<AbsenceWindow> ExportedAbsenceWindows { get; set; }
  }
}
