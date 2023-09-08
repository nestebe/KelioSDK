
//.ImportOvertimeLimits




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importOvertimeLimits")]
  public class ImportOvertimeLimits
  {
    [XmlArray(ElementName = "overtimeLimitsToImport", IsNullable = false, Order = 0)]
    public List<OvertimeLimit> OvertimeLimitsToImport { get; set; }
  }
}
