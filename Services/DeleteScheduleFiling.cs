
//.DeleteScheduleFiling




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "deleteScheduleFiling")]
  public class DeleteScheduleFiling
  {
    [XmlArray(ElementName = "scheduleFilingToDelete", IsNullable = false, Order = 0)]
    public List<Filing> ScheduleFilingToDelete { get; set; }
  }
}
