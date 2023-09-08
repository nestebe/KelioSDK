
//.ImportDailySchedulesResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importDailySchedulesResponse")]
  public class ImportDailySchedulesResponse
  {
    [XmlArray(ElementName = "dailySchedulesInError", IsNullable = false, Order = 0)]
    public List<DailySchedule> DailySchedulesInError { get; set; }
  }
}
