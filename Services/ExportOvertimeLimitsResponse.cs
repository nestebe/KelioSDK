
//.ExportOvertimeLimitsResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportOvertimeLimitsResponse")]
  public class ExportOvertimeLimitsResponse
  {
    [XmlArray(ElementName = "exportedOvertimeLimits", IsNullable = false, Order = 0)]
    public List<OvertimeLimit> ExportedOvertimeLimits { get; set; }
  }
}
