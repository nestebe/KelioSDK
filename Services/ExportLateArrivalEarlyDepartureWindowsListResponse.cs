
//.ExportLateArrivalEarlyDepartureWindowsListResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportLateArrivalEarlyDepartureWindowsListResponse")]
  public class ExportLateArrivalEarlyDepartureWindowsListResponse
  {
    [XmlArray(ElementName = "exportedLateArrivalEarlyDepartureWindows", IsNullable = false, Order = 0)]
    public List<LateArrivalEarlyDepartureWindow> ExportedLateArrivalEarlyDepartureWindows { get; set; }
  }
}
