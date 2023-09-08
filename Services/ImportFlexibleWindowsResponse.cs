
//.ImportFlexibleWindowsResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importFlexibleWindowsResponse")]
  public class ImportFlexibleWindowsResponse
  {
    [XmlArray(ElementName = "flexibleWindowsInError", IsNullable = false, Order = 0)]
    public List<FlexibleWindow> FlexibleWindowsInError { get; set; }
  }
}
