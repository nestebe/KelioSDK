
//.ExportPaidBreakWithConditionalDurationWindowsResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportPaidBreakWithConditionalDurationWindowsResponse")]
  public class ExportPaidBreakWithConditionalDurationWindowsResponse
  {
    [XmlArray(ElementName = "exportedPaidBreakWithConditionalDurationWindows", IsNullable = false, Order = 0)]
    public List<PaidBreakWithConditionalDurationWindow> ExportedPaidBreakWithConditionalDurationWindows { get; set; }
  }
}
