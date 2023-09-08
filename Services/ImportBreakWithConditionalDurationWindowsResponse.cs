
//.ImportBreakWithConditionalDurationWindowsResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importBreakWithConditionalDurationWindowsResponse")]
  public class ImportBreakWithConditionalDurationWindowsResponse
  {
    [XmlArray(ElementName = "breakWithConditionalDurationWindowsInError", IsNullable = false, Order = 0)]
    public List<BreakWithConditionalDurationWindow> BreakWithConditionalDurationWindowsInError { get; set; }
  }
}
