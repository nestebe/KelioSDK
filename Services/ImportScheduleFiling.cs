
//.ImportScheduleFiling




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importScheduleFiling")]
  public class ImportScheduleFiling
  {
    [XmlArray(ElementName = "scheduleFilingToImport", IsNullable = false, Order = 0)]
    public List<Filing> ScheduleFilingToImport { get; set; }
  }
}
