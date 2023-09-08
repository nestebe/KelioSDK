
//.ExportSchedulesResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportSchedulesResponse")]
  public class ExportSchedulesResponse
  {
    [XmlArray(ElementName = "exportedSchedules", IsNullable = false, Order = 0)]
    public List<Schedule> ExportedSchedules { get; set; }
  }
}
