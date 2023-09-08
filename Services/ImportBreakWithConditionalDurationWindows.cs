
//.ImportBreakWithConditionalDurationWindows




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importBreakWithConditionalDurationWindows")]
  public class ImportBreakWithConditionalDurationWindows
  {
    [XmlArray(ElementName = "breakWithConditionalDurationWindowsToImport", IsNullable = false, Order = 0)]
    public List<BreakWithConditionalDurationWindow> BreakWithConditionalDurationWindowsToImport { get; set; }
  }
}
