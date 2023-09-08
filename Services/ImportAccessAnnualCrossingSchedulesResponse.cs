
//.ImportAccessAnnualCrossingSchedulesResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importAccessAnnualCrossingSchedulesResponse")]
  public class ImportAccessAnnualCrossingSchedulesResponse
  {
    [XmlArray(ElementName = "accessAnnualCrossingSchedulesInError", IsNullable = false, Order = 0)]
    public List<AccessAnnualCrossingSchedule> AccessAnnualCrossingSchedulesInError { get; set; }
  }
}
