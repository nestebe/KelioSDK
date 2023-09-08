
//.ImportDailyScheduleFiling




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importDailyScheduleFiling")]
  public class ImportDailyScheduleFiling
  {
    [XmlArray(ElementName = "dailyScheduleFilingToImport", IsNullable = false, Order = 0)]
    public List<Filing> DailyScheduleFilingToImport { get; set; }
  }
}
