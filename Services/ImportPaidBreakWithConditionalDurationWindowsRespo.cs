
//.ImportPaidBreakWithConditionalDurationWindowsResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importPaidBreakWithConditionalDurationWindowsResponse")]
  public class ImportPaidBreakWithConditionalDurationWindowsResponse
  {
    [XmlArray(ElementName = "paidBreakWithConditionalDurationWindowsInError", IsNullable = false, Order = 0)]
    public List<PaidBreakWithConditionalDurationWindow> PaidBreakWithConditionalDurationWindowsInError { get; set; }
  }
}
