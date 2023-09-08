
//.ExportDailyScheduleFilingResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportDailyScheduleFilingResponse")]
  public class ExportDailyScheduleFilingResponse
  {
    [XmlArray(ElementName = "exportedDailyScheduleFiling", IsNullable = false, Order = 0)]
    public List<Filing> ExportedDailyScheduleFiling { get; set; }
  }
}
