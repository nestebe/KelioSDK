
//.DeleteDailyScheduleWindowsList




using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "deleteDailyScheduleWindowsList")]
  public class DeleteDailyScheduleWindowsList
  {
    [XmlArray(ElementName = "askedWindowWithType", IsNullable = false, Order = 0)]
    public List<KelioSDK.Models.AskedWindowWithType> AskedWindowWithType { get; set; }
  }
}
