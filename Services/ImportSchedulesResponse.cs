
//.ImportSchedulesResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importSchedulesResponse")]
  public class ImportSchedulesResponse
  {
    [XmlArray(ElementName = "schedulesInError", IsNullable = false, Order = 0)]
    public List<Schedule> SchedulesInError { get; set; }
  }
}
