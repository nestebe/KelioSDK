
//.ExportFireReportPeoplePresent




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportFireReportPeoplePresent")]
  public class ExportFireReportPeoplePresent
  {
    [XmlArray(ElementName = "filterList", IsNullable = false, Order = 0)]
    public List<FireReportFilter> FilterList { get; set; }
  }
}
