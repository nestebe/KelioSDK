
//.ExportDailySchedulesResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportDailySchedulesResponse")]
  public class ExportDailySchedulesResponse
  {
    [XmlArray(ElementName = "exportedDailySchedules", IsNullable = false, Order = 0)]
    public List<DailySchedule> ExportedDailySchedules { get; set; }
  }
}
