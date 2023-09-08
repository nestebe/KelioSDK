
//.ImportOvertimeHoursWindows




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importOvertimeHoursWindows")]
  public class ImportOvertimeHoursWindows
  {
    [XmlArray(ElementName = "overtimeHoursWindowsToImport", IsNullable = false, Order = 0)]
    public List<OvertimeHoursWindow> OvertimeHoursWindowsToImport { get; set; }
  }
}
