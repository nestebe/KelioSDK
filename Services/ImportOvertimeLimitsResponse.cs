
//.ImportOvertimeLimitsResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importOvertimeLimitsResponse")]
  public class ImportOvertimeLimitsResponse
  {
    [XmlArray(ElementName = "overtimeLimitsInError", IsNullable = false, Order = 0)]
    public List<OvertimeLimit> OvertimeLimitsInError { get; set; }
  }
}
