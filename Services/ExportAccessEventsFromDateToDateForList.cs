
//.ExportAccessEventsFromDateToDateForList




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportAccessEventsFromDateToDateForList")]
  public class ExportAccessEventsFromDateToDateForList
  {
    [XmlArray(ElementName = "filterList", IsNullable = false, Order = 0)]
    public List<AskedAccessEventFromDateToDate> FilterList { get; set; }
  }
}
