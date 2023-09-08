
//.ExportPerpetualAccountTotals




using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportPerpetualAccountTotals")]
  public class ExportPerpetualAccountTotals
  {
    [XmlArray(ElementName = "accountFilter", IsNullable = false, Order = 0)]
    public List<KelioSDK.Models.AccountFilter> AccountFilter { get; set; }
  }
}
