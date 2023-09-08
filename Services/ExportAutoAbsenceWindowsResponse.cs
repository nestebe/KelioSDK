
//.ExportAutoAbsenceWindowsResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportAutoAbsenceWindowsResponse")]
  public class ExportAutoAbsenceWindowsResponse
  {
    [XmlArray(ElementName = "exportedAutoAbsenceWindows", IsNullable = false, Order = 0)]
    public List<AutoAbsenceWindow> ExportedAutoAbsenceWindows { get; set; }
  }
}
