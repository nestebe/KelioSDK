
//.ImportFlexibleWindows




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importFlexibleWindows")]
  public class ImportFlexibleWindows
  {
    [XmlArray(ElementName = "flexibleWindowsToImport", IsNullable = false, Order = 0)]
    public List<FlexibleWindow> FlexibleWindowsToImport { get; set; }
  }
}
