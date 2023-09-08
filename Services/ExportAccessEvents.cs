
//.ExportAccessEvents




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportAccessEvents")]
  public class ExportAccessEvents
  {
    [XmlArray(ElementName = "filterList", IsNullable = false, Order = 0)]
    public List<AskedAccessEventFromPeriod> FilterList { get; set; }
  }
}
