
//.ExportAbsenceWindowsListResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportAbsenceWindowsListResponse")]
  public class ExportAbsenceWindowsListResponse
  {
    [XmlArray(ElementName = "exportedAbsenceWindows", IsNullable = false, Order = 0)]
    public List<AbsenceWindow> ExportedAbsenceWindows { get; set; }
  }
}
