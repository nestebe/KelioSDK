
//.ImportTwoAccountsOvertimeHoursWindows




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importTwoAccountsOvertimeHoursWindows")]
  public class ImportTwoAccountsOvertimeHoursWindows
  {
    [XmlArray(ElementName = "twoAccountsOvertimeHoursWindowsToImport", IsNullable = false, Order = 0)]
    public List<TwoAccountsOvertimeHoursWindow> TwoAccountsOvertimeHoursWindowsToImport { get; set; }
  }
}
