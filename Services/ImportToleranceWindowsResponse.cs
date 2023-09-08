
//.ImportToleranceWindowsResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importToleranceWindowsResponse")]
  public class ImportToleranceWindowsResponse
  {
    [XmlArray(ElementName = "toleranceWindowsInError", IsNullable = false, Order = 0)]
    public List<ToleranceWindow> ToleranceWindowsInError { get; set; }
  }
}
