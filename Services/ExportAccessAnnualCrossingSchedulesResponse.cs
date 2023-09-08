
//.ExportAccessAnnualCrossingSchedulesResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportAccessAnnualCrossingSchedulesResponse")]
  public class ExportAccessAnnualCrossingSchedulesResponse
  {
    [XmlArray(ElementName = "exportedAccessAnnualCrossingSchedules", IsNullable = false, Order = 0)]
    public List<AccessAnnualCrossingSchedule> ExportedAccessAnnualCrossingSchedules { get; set; }
  }
}
