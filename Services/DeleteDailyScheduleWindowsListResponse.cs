
//.DeleteDailyScheduleWindowsListResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "deleteDailyScheduleWindowsListResponse")]
  public class DeleteDailyScheduleWindowsListResponse
  {
    [XmlArray(ElementName = "deleteDailyScheduleWindows", IsNullable = false, Order = 0)]
    public List<DailyScheduleWindow> DeleteDailyScheduleWindows { get; set; }
  }
}
