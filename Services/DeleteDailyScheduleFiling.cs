
//.DeleteDailyScheduleFiling




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "deleteDailyScheduleFiling")]
  public class DeleteDailyScheduleFiling
  {
    [XmlArray(ElementName = "dailyScheduleFilingToDelete", IsNullable = false, Order = 0)]
    public List<Filing> DailyScheduleFilingToDelete { get; set; }
  }
}
