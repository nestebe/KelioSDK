
//.ExportPaidBreakWithConditionalDurationWindowsListResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportPaidBreakWithConditionalDurationWindowsListResponse")]
  public class ExportPaidBreakWithConditionalDurationWindowsListResponse
  {
    [XmlArray(ElementName = "exportedPaidBreakWithConditionalDurationWindows", IsNullable = false, Order = 0)]
    public List<PaidBreakWithConditionalDurationWindow> ExportedPaidBreakWithConditionalDurationWindows { get; set; }
  }
}
