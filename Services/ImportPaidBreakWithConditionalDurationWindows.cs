
//.ImportPaidBreakWithConditionalDurationWindows




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importPaidBreakWithConditionalDurationWindows")]
  public class ImportPaidBreakWithConditionalDurationWindows
  {
    [XmlArray(ElementName = "paidBreakWithConditionalDurationWindowsToImport", IsNullable = false, Order = 0)]
    public List<PaidBreakWithConditionalDurationWindow> PaidBreakWithConditionalDurationWindowsToImport { get; set; }
  }
}
