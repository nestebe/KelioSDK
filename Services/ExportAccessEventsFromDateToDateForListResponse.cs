
//.ExportAccessEventsFromDateToDateForListResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportAccessEventsFromDateToDateForListResponse")]
  public class ExportAccessEventsFromDateToDateForListResponse
  {
    [XmlArray(ElementName = "exportedAccessEvents", IsNullable = false, Order = 0)]
    public List<AccessEvent> ExportedAccessEvents { get; set; }
  }
}
