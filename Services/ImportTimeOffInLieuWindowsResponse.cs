
//.ImportTimeOffInLieuWindowsResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importTimeOffInLieuWindowsResponse")]
  public class ImportTimeOffInLieuWindowsResponse
  {
    [XmlArray(ElementName = "timeOffInLieuWindowsInError", IsNullable = false, Order = 0)]
    public List<TimeOffInLieuWindow> TimeOffInLieuWindowsInError { get; set; }
  }
}
